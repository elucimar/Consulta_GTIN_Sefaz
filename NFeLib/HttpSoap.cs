using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace NFeLib
{
    public class HttpSoap
    {
        private readonly string _url;
        private readonly X509Certificate2 _certificadoDigital;
        private readonly int _timeout = 30000;

        public HttpSoap(string url, X509Certificate2 certDigital)
        {
            _url = url;
            _certificadoDigital = certDigital;
        }

        public string GetErros { get; private set; } = string.Empty;

        public XmlDocument XmlRetornoSefaz { get; set; }

        public async Task<RetConsGTIN> ConsultaGTIN(XmlDocument xmlDoc)
        {
            return await Enviar<RetConsGTIN>(xmlDoc, nomeClasseRetorno: "retConsGTIN");
        }

        private async Task<T> Enviar<T>(XmlDocument xmlDoc, bool deserializar = true, bool criarSoap = true, string nomeClasseRetorno = "") where T : class, new()
        {
            XmlRetornoSefaz = null;
            XmlDocument xmlSoapEnvio = criarSoap ? SoapXml(xmlDoc) : xmlDoc;

            XmlDocument xmlRetorno = await Enviar(xmlSoapEnvio);
            if (xmlRetorno == null)
                return null;

            XmlDocument xmlSerializar = ExtractNodesXmlSoap(xmlRetorno, (nomeClasseRetorno.Length > 0 ? nomeClasseRetorno : new T().GetType().Name));
            if (xmlSerializar == null)
                return null;

            XmlRetornoSefaz = xmlSerializar;
            return deserializar
                ? FuncoesXml.DeserializeXmlToObject<T>(xmlSerializar.OuterXml)
                : (T)(object)xmlSerializar;
        }

        private async Task<XmlDocument> Enviar(XmlDocument soapXml)
        {

            string stringXml = soapXml.OuterXml;
            HttpClientHandler handler = new HttpClientHandler();
            CancellationTokenSource cts = new CancellationTokenSource();
            HttpResponseMessage response = null;
            HttpClient client = null;

            if (_certificadoDigital == null)
            {
                GetErros = "Certificado digital inválido!";
                return null;
            }

            try
            {
                foreach (var clientCertificate in handler.ClientCertificates)
                    handler.ClientCertificates.Remove(clientCertificate);

                handler.ClientCertificates.Add(_certificadoDigital);
                handler.ServerCertificateCustomValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

                using (client = new HttpClient(handler))
                {
                    client.Timeout = new TimeSpan(0, 0, 0, 0, _timeout);
                    var uri = new Uri(_url);
                    var request = new HttpRequestMessage(HttpMethod.Post, uri);
                    request.Content = new StringContent(stringXml, Encoding.UTF8, "application/soap+xml");
                    request.Headers.Clear();
                    request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/soap+xml");
                    request.Headers.Host = uri.Host;
                    var servico = ObterServico(_url);
                    request.Headers.Add("SOAPAction", $"{servico}");

                    response = await client.SendAsync(request, cts.Token);
                    if (!response.IsSuccessStatusCode)
                    {
                        GetErros = ($"Não foi possível estabelecer uma conexão com o host {response.StatusCode}");
                        return null;
                    }

                    Stream stream = await response.Content.ReadAsStreamAsync();
                    XmlDocument xmlRetorno = new XmlDocument();
                    xmlRetorno.Load(stream);
                    return xmlRetorno;
                }

            }
            catch (Exception ex)
            {
                string erroTimeout = (response?.StatusCode ?? HttpStatusCode.NotFound) == HttpStatusCode.RequestTimeout ? "(Timeout)" : "";
                GetErros = $"Falha de comunicação{erroTimeout} ao executar o serviço na Sefaz: {ex.Message}";
                return null;
            }
        }

        private XmlDocument ExtractNodesXmlSoap(XmlDocument xmlDoc, string tag)
        {
            try
            {
                XmlNodeList xmlList = xmlDoc.GetElementsByTagName(tag);
                XmlDocument xmlRetorno = new XmlDocument();
                xmlRetorno.LoadXml(xmlList[0].OuterXml);
                return xmlRetorno;
            }

            catch (Exception ex)
            {
                GetErros = ex.Message;
                return null;
            }
        }

        private XmlDocument SoapXml(XmlDocument xmlDoc)
        {
            try
            {
                if (xmlDoc.FirstChild is XmlDeclaration)
                    xmlDoc.RemoveChild(xmlDoc.FirstChild);

                string nsRoot = "http://www.w3.org/2003/05/soap-envelope";
                XmlDocument xmlSoap = new XmlDocument();

                XmlElement envelope = xmlSoap.CreateElement("soap12:Envelope", nsRoot);

                XmlElement body = xmlSoap.CreateElement("soap12", "Body", nsRoot);
                body.InnerXml = xmlDoc.InnerXml;
                envelope.AppendChild(body);

                xmlSoap.AppendChild(envelope);
                return xmlSoap;
            }

            catch (Exception ex)
            {
                GetErros = ex.Message;
                return null;
            }
        }

        private string ObterServico(string url)
        {
            var reg1 = "[^/]+(?=(?:\\.[^.]+)?$)";
            var regex = new Regex(reg1);
            var nomeComExtensao = regex.Match(url);
            var t1 = "([^\\.]*)";
            var regex2 = new Regex(t1);
            var nome = regex2.Match(nomeComExtensao.Value);
            return nome.Value;
        }
    }
}