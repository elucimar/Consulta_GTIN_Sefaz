using NFeLib;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TestesNFe
{
    public partial class FrmTestesNFe : Form
    {
        private X509Certificate2 _x509Certificate2 = null;
        public FrmTestesNFe()
        {
            InitializeComponent();
        }

        private void FrmTestesNFe_Load(object sender, EventArgs e)
        {
            gridRetorno.AutoGenerateColumns = false;
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }

        private async void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBarra.Text))
            {
                MessageBox.Show("Digitar um Código de Barras", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoBarra.Focus();
                return;
            }

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