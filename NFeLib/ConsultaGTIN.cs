using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFeLib
{
    [XmlRoot(ElementName = "ccgConsGTIN", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/ccgConsGtin")]
    public class EnvConsGTIN
    {
        [XmlElement(ElementName = "nfeDadosMsg")]
        public NFeDadosMsg NFeDadosMsg { get; set; } = new NFeDadosMsg();
    }

    public class NFeDadosMsg
    {
        [XmlElement(ElementName = "consGTIN",Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public ConsultaGTIN ConsultaGTIN { get; set; }

    }

    public class ConsultaGTIN
    {

        [XmlAttribute(AttributeName = "versao")]
        public string Versao { get; set; }

        public string GTIN { get; set; }

        public ConsultaGTIN()
        {
        }

        public ConsultaGTIN(string gtin)
        {
            GTIN = gtin;
            Versao = "1.00";
        }
    }

    [XmlRoot(ElementName = "retConsGTIN", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class RetConsGTIN
    {
        [XmlElement(ElementName = "verAplic")]
        public string VerAplic { get; set; }

        [XmlElement(ElementName = "cStat")]
        public string CStat { get; set; }

        [XmlElement(ElementName = "xMotivo")]
        public string XMotivo { get; set; }

        [XmlElement(ElementName = "dhResp")]
        public DateTime DhResp { get; set; }

        public string GTIN { get; set; }
        [XmlElement(ElementName = "tpGTIN")]

        public string TpGTIN { get; set; }

        [XmlElement(ElementName = "xProd")]
        public string XProd { get; set; }

        public string NCM { get; set; }
        
        [XmlAttribute(AttributeName = "versao")]
        public string Versao { get; set; }
    }

}
