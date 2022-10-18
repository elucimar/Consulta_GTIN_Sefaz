namespace TestesNFe
{
    partial class FrmTestesNFe
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRetorno = new System.Windows.Forms.DataGridView();
            this.pesquisaPanel = new System.Windows.Forms.Panel();
            this.dadosPanel = new System.Windows.Forms.Panel();
            this.CStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TpGTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerAplic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DhResp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRetorno)).BeginInit();
            this.pesquisaPanel.SuspendLayout();
            this.dadosPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(152, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(77, 35);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(6, 25);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(140, 20);
            this.txtCodigoBarra.TabIndex = 1;
            this.txtCodigoBarra.Text = "78933354";
            this.txtCodigoBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Barras";
            // 
            // gridRetorno
            // 
            this.gridRetorno.AllowUserToAddRows = false;
            this.gridRetorno.AllowUserToDeleteRows = false;
            this.gridRetorno.AllowUserToResizeColumns = false;
            this.gridRetorno.AllowUserToResizeRows = false;
            this.gridRetorno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridRetorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRetorno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CStat,
            this.XMotivo,
            this.GTIN,
            this.TpGTIN,
            this.XProd,
            this.NCM,
            this.CEST,
            this.VerAplic,
            this.DhResp});
            this.gridRetorno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRetorno.Location = new System.Drawing.Point(0, 0);
            this.gridRetorno.MultiSelect = false;
            this.gridRetorno.Name = "gridRetorno";
            this.gridRetorno.ReadOnly = true;
            this.gridRetorno.RowHeadersVisible = false;
            this.gridRetorno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRetorno.Size = new System.Drawing.Size(924, 217);
            this.gridRetorno.TabIndex = 0;
            // 
            // pesquisaPanel
            // 
            this.pesquisaPanel.Controls.Add(this.label1);
            this.pesquisaPanel.Controls.Add(this.btnConsultar);
            this.pesquisaPanel.Controls.Add(this.txtCodigoBarra);
            this.pesquisaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pesquisaPanel.Location = new System.Drawing.Point(0, 0);
            this.pesquisaPanel.Name = "pesquisaPanel";
            this.pesquisaPanel.Size = new System.Drawing.Size(924, 53);
            this.pesquisaPanel.TabIndex = 0;
            // 
            // dadosPanel
            // 
            this.dadosPanel.Controls.Add(this.gridRetorno);
            this.dadosPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dadosPanel.Location = new System.Drawing.Point(0, 53);
            this.dadosPanel.Name = "dadosPanel";
            this.dadosPanel.Size = new System.Drawing.Size(924, 217);
            this.dadosPanel.TabIndex = 1;
            // 
            // CStat
            // 
            this.CStat.DataPropertyName = "CStat";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CStat.DefaultCellStyle = dataGridViewCellStyle15;
            this.CStat.HeaderText = "CStat";
            this.CStat.Name = "CStat";
            this.CStat.ReadOnly = true;
            this.CStat.Width = 50;
            // 
            // XMotivo
            // 
            this.XMotivo.DataPropertyName = "XMotivo";
            this.XMotivo.HeaderText = "XMotivo";
            this.XMotivo.Name = "XMotivo";
            this.XMotivo.ReadOnly = true;
            this.XMotivo.Width = 150;
            // 
            // GTIN
            // 
            this.GTIN.DataPropertyName = "GTIN";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GTIN.DefaultCellStyle = dataGridViewCellStyle16;
            this.GTIN.HeaderText = "GTIN";
            this.GTIN.Name = "GTIN";
            this.GTIN.ReadOnly = true;
            // 
            // TpGTIN
            // 
            this.TpGTIN.DataPropertyName = "TpGTIN";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TpGTIN.DefaultCellStyle = dataGridViewCellStyle17;
            this.TpGTIN.HeaderText = "Tp";
            this.TpGTIN.Name = "TpGTIN";
            this.TpGTIN.ReadOnly = true;
            this.TpGTIN.Width = 30;
            // 
            // XProd
            // 
            this.XProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.XProd.DataPropertyName = "XProd";
            this.XProd.HeaderText = "XProd";
            this.XProd.Name = "XProd";
            this.XProd.ReadOnly = true;
            // 
            // NCM
            // 
            this.NCM.DataPropertyName = "NCM";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NCM.DefaultCellStyle = dataGridViewCellStyle18;
            this.NCM.HeaderText = "NCM";
            this.NCM.Name = "NCM";
            this.NCM.ReadOnly = true;
            this.NCM.Width = 60;
            // 
            // CEST
            // 
            this.CEST.DataPropertyName = "CEST";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CEST.DefaultCellStyle = dataGridViewCellStyle19;
            this.CEST.HeaderText = "CEST";
            this.CEST.Name = "CEST";
            this.CEST.ReadOnly = true;
            this.CEST.Width = 60;
            // 
            // VerAplic
            // 
            this.VerAplic.DataPropertyName = "VerAplic";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.VerAplic.DefaultCellStyle = dataGridViewCellStyle20;
            this.VerAplic.HeaderText = "VerAplic";
            this.VerAplic.Name = "VerAplic";
            this.VerAplic.ReadOnly = true;
            this.VerAplic.Width = 130;
            // 
            // DhResp
            // 
            this.DhResp.DataPropertyName = "DhResp";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DhResp.DefaultCellStyle = dataGridViewCellStyle21;
            this.DhResp.HeaderText = "DhResp";
            this.DhResp.Name = "DhResp";
            this.DhResp.ReadOnly = true;
            // 
            // FrmTestesNFe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(924, 270);
            this.Controls.Add(this.dadosPanel);
            this.Controls.Add(this.pesquisaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTestesNFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta GTIN";
            this.Load += new System.EventHandler(this.FrmTestesNFe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRetorno)).EndInit();
            this.pesquisaPanel.ResumeLayout(false);
            this.pesquisaPanel.PerformLayout();
            this.dadosPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRetorno;
        private System.Windows.Forms.Panel pesquisaPanel;
        private System.Windows.Forms.Panel dadosPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TpGTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn XProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerAplic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DhResp;
    }
}

