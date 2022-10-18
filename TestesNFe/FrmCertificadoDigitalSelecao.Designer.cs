namespace TestesNFe
{
    partial class FrmCertificadoDigitalSelecao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxBody = new System.Windows.Forms.GroupBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.gbxBotton = new System.Windows.Forms.GroupBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.FriendlyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelecionado = new System.Windows.Forms.Label();
            this.gbxBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.gbxBotton.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBody
            // 
            this.gbxBody.Controls.Add(this.dg);
            this.gbxBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxBody.Location = new System.Drawing.Point(0, 0);
            this.gbxBody.Name = "gbxBody";
            this.gbxBody.Size = new System.Drawing.Size(800, 172);
            this.gbxBody.TabIndex = 2;
            this.gbxBody.TabStop = false;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FriendlyName,
            this.SerialNumber,
            this.NotAfter});
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.Location = new System.Drawing.Point(3, 16);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(794, 153);
            this.dg.TabIndex = 0;
            this.dg.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_CellMouseDoubleClick);
            this.dg.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_RowEnter);
            this.dg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_KeyDown);
            // 
            // gbxBotton
            // 
            this.gbxBotton.Controls.Add(this.lblSelecionado);
            this.gbxBotton.Controls.Add(this.btnCancelar);
            this.gbxBotton.Controls.Add(this.btnSelecionar);
            this.gbxBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxBotton.Location = new System.Drawing.Point(0, 172);
            this.gbxBotton.Name = "gbxBotton";
            this.gbxBotton.Size = new System.Drawing.Size(800, 55);
            this.gbxBotton.TabIndex = 3;
            this.gbxBotton.TabStop = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(634, 14);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(77, 35);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(717, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FriendlyName
            // 
            this.FriendlyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FriendlyName.HeaderText = "Certificado";
            this.FriendlyName.Name = "FriendlyName";
            this.FriendlyName.ReadOnly = true;
            // 
            // SerialNumber
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SerialNumber.DefaultCellStyle = dataGridViewCellStyle8;
            this.SerialNumber.HeaderText = "Nr.Série";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Width = 200;
            // 
            // NotAfter
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NotAfter.DefaultCellStyle = dataGridViewCellStyle9;
            this.NotAfter.HeaderText = "Validade";
            this.NotAfter.Name = "NotAfter";
            this.NotAfter.ReadOnly = true;
            // 
            // lblSelecionado
            // 
            this.lblSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionado.Location = new System.Drawing.Point(6, 9);
            this.lblSelecionado.Name = "lblSelecionado";
            this.lblSelecionado.Size = new System.Drawing.Size(622, 42);
            this.lblSelecionado.TabIndex = 5;
            this.lblSelecionado.Text = "[lblSelecionado]";
            this.lblSelecionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCertificadoDigitalSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 227);
            this.ControlBox = false;
            this.Controls.Add(this.gbxBody);
            this.Controls.Add(this.gbxBotton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCertificadoDigitalSelecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecionar o Certificado";
            this.Load += new System.EventHandler(this.FrmCertificadoDigitalSelecao_Load);
            this.gbxBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.gbxBotton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBody;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.GroupBox gbxBotton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriendlyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotAfter;
        private System.Windows.Forms.Label lblSelecionado;
    }
}