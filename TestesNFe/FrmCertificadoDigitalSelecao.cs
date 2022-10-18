using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace TestesNFe
{
    public partial class FrmCertificadoDigitalSelecao : Form
    {
        public string mSerialNumber { get; set; }
        bool mPressEnter = false;

        void CertificadoSelecionado()
        {
            lblSelecionado.Text = "";
            try
            {
                if (dg.Rows.Count > 0 && dg.CurrentRow != null)
                {
                    mSerialNumber = dg.SelectedRows[0].Cells[1].Value.ToString();
                    lblSelecionado.Text = dg.SelectedRows[0].Cells[0].Value.ToString() + "\r\nSERIAL: " + dg.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
            catch { }
        }

        public FrmCertificadoDigitalSelecao()
        {
            InitializeComponent();
        }

        private void FrmCertificadoDigitalSelecao_Load(object sender, EventArgs e)
        {
            List<X509Certificate2> lst = DigitalCertificateAgent.ListOnlyValidCerticates(StoreName.My, StoreLocation.CurrentUser);
            if (lst != null && lst.Count > 0)
            {
                foreach (var item in lst)
                    dg.Rows.Add(item.Subject, item.SerialNumber, item.NotAfter.ToString("dd/MM/yyyy HH:mm"));

                ActiveControl = dg;
                dg.Focus();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dg_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CertificadoSelecionado();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mPressEnter = true;
                CertificadoSelecionado();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void dg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (mPressEnter)
            {
                mPressEnter = false;
                return;
            }
            CertificadoSelecionado();
        }
    }
}
