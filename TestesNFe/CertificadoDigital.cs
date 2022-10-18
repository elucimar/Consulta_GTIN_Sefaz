using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace TestesNFe
{
    public class CertificadoDigital
    {
        public string GetErros { get; set; } = "";

        public X509Certificate2 SelecionarCertificado(string serieCertDig)
        {
            X509Certificate2 certificate = new X509Certificate2();
            try
            {
                X509Certificate2Collection certificatesSel = null;
                X509Store store = new X509Store("MY", StoreLocation.CurrentUser);
                store.Open(OpenFlags.OpenExistingOnly);

                X509Certificate2Collection certificates =
                    store.Certificates.Find(X509FindType.FindByTimeValid, DateTime.Now, true)
                        .Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, true);
                
                if ((string.IsNullOrEmpty(serieCertDig)))
                {
                    certificatesSel = X509Certificate2UI.SelectFromCollection(certificates, "Certificados Digitais",
                        "Selecione o Certificado Digital para uso no aplicativo", X509SelectionFlag.SingleSelection);
                    if ((certificatesSel.Count == 0))
                    {
                        GetErros = "Nenhum certificado digital foi selecionado ou o certificado selecionado está com problemas.";
                        return null;
                    }
                     
                    return certificatesSel[0];
                    
                }
                
                certificatesSel = certificates.Find(X509FindType.FindBySerialNumber, serieCertDig, true);
                if (certificatesSel?.Count == 0)
                {
                    GetErros = "Certificado digital não encontrado";
                    return null;
                }
                return certificatesSel[0];
 
            }
            catch (Exception)
            {
                GetErros = "Falha detectada ao verificar o certificado";
            }

            return certificate;
        }
    }
}