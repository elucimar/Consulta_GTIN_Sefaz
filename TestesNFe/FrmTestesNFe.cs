using NFeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace TestesNFe
{
    public partial class FrmTestesNFe : Form
    {
        private X509Certificate2 _x509Certificate2 = null;
        public FrmTestesNFe()
        {
            InitializeComponent();
        }

        private async void BtnConsultar_Click(object sender, EventArgs e)
        {

            btnConsultar.Enabled = false;
            if (_x509Certificate2 == null)
            {
                CertificadoDigital certificadoDigital = new CertificadoDigital();
                _x509Certificate2 = certificadoDigital.SelecionarCertificado("");
            }

            EnvConsGTIN envConsGTIN = new EnvConsGTIN();
            envConsGTIN.NFeDadosMsg.ConsultaGTIN = new ConsultaGTIN(txtCodigoBarra.Text);
            XmlDocument xmlConsultaGTIN = FuncoesXml.Serialize(envConsGTIN, Encoding.UTF8);

            HttpSoap httpSoap = new HttpSoap("https://dfe-servico.svrs.rs.gov.br/ws/ccgConsGTIN/ccgConsGTIN.asmx", _x509Certificate2);
            RetConsGTIN retConsGTIN = await httpSoap.ConsultaGTIN(xmlConsultaGTIN);
            btnConsultar.Enabled = true;

            gridRetorno.DataSource = new List<RetConsGTIN> { retConsGTIN };
            if (httpSoap.GetErros.Length > 0)
            {
                MessageBox.Show(httpSoap.GetErros, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        
    }
}
