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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRetorno = new System.Windows.Forms.DataGridView();
            this.CStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TpGTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerAplic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DhResp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRetorno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(217, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(145, 35);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(25, 37);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(176, 20);
            this.txtCodigoBarra.TabIndex = 1;
            this.txtCodigoBarra.Text = "78933354";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de barra";
            // 
            // gridRetorno
            // 
            this.gridRetorno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridRetorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRetorno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CStat,
            this.XMotivo,
            this.GTIN,
            this.TpGTIN,
            this.XProd,
            this.NCM,
            this.VerAplic,
            this.DhResp});
            this.gridRetorno.Location = new System.Drawing.Point(12, 80);
            this.gridRetorno.Name = "gridRetorno";
            this.gridRetorno.Size = new System.Drawing.Size(843, 261);
            this.gridRetorno.TabIndex = 3;
            // 
            // CStat
            // 
            this.CStat.DataPropertyName = "CStat";
            this.CStat.HeaderText = "CStat";
            this.CStat.Name = "CStat";
            this.CStat.Width = 50;
            // 
            // XMotivo
            // 
            this.XMotivo.DataPropertyName = "XMotivo";
            this.XMotivo.HeaderText = "XMotivo";
            this.XMotivo.Name = "XMotivo";
            this.XMotivo.Width = 200;
            // 
            // GTIN
            // 
            this.GTIN.DataPropertyName = "GTIN";
            this.GTIN.HeaderText = "GTIN";
            this.GTIN.Name = "GTIN";
            this.GTIN.Width = 150;
            // 
            // TpGTIN
            // 
            this.TpGTIN.DataPropertyName = "TpGTIN";
            this.TpGTIN.HeaderText = "TpGTIN";
            this.TpGTIN.Name = "TpGTIN";
            // 
            // XProd
            // 
            this.XProd.DataPropertyName = "XProd";
            this.XProd.HeaderText = "XProd";
            this.XProd.Name = "XProd";
            this.XProd.Width = 200;
            // 
            // NCM
            // 
            this.NCM.DataPropertyName = "NCM";
            this.NCM.HeaderText = "NCM";
            this.NCM.Name = "NCM";
            // 
            // VerAplic
            // 
            this.VerAplic.DataPropertyName = "VerAplic";
            this.VerAplic.HeaderText = "VerAplic";
            this.VerAplic.Name = "VerAplic";
            // 
            // DhResp
            // 
            this.DhResp.DataPropertyName = "DhResp";
            this.DhResp.HeaderText = "DhResp";
            this.DhResp.Name = "DhResp";
            // 
            // FrmTestesNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.gridRetorno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.btnConsultar);
            this.Name = "FrmTestesNFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta GTIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridRetorno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TpGTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn XProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerAplic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DhResp;
    }
}

