
namespace TestesWindowsForms
{
    partial class FrmConsultaCep
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCep));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lbllCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtLogadouro = new System.Windows.Forms.TextBox();
            this.lblLogadouro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.pnl.Controls.Add(this.pictureBox1);
            this.pnl.Location = new System.Drawing.Point(3, 3);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(472, 77);
            this.pnl.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.lblLogadouro);
            this.panel1.Controls.Add(this.txtLogadouro);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtCEP);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.txtCidade);
            this.panel1.Controls.Add(this.lbllCidade);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.Controls.Add(this.lblCEP);
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 317);
            this.panel1.TabIndex = 2;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCEP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCEP.Location = new System.Drawing.Point(12, 19);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(38, 15);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "label1";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBairro.Location = new System.Drawing.Point(12, 184);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 15);
            this.lblBairro.TabIndex = 1;
            this.lblBairro.Text = "label1";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado.Location = new System.Drawing.Point(12, 131);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(38, 15);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "label1";
            // 
            // lbllCidade
            // 
            this.lbllCidade.AutoSize = true;
            this.lbllCidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllCidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbllCidade.Location = new System.Drawing.Point(12, 78);
            this.lbllCidade.Name = "lbllCidade";
            this.lbllCidade.Size = new System.Drawing.Size(38, 15);
            this.lbllCidade.TabIndex = 3;
            this.lbllCidade.Text = "label1";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(15, 94);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(340, 21);
            this.txtCidade.TabIndex = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtEstado.Location = new System.Drawing.Point(15, 147);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(340, 21);
            this.txtEstado.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtBairro.Location = new System.Drawing.Point(15, 200);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(340, 21);
            this.txtBairro.TabIndex = 6;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(15, 35);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(116, 20);
            this.txtCEP.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(155, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 36);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(267, 26);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 36);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "button1";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtLogadouro
            // 
            this.txtLogadouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogadouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtLogadouro.Location = new System.Drawing.Point(15, 245);
            this.txtLogadouro.Name = "txtLogadouro";
            this.txtLogadouro.Size = new System.Drawing.Size(340, 21);
            this.txtLogadouro.TabIndex = 11;
            // 
            // lblLogadouro
            // 
            this.lblLogadouro.AutoSize = true;
            this.lblLogadouro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLogadouro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogadouro.Location = new System.Drawing.Point(12, 229);
            this.lblLogadouro.Name = "lblLogadouro";
            this.lblLogadouro.Size = new System.Drawing.Size(38, 15);
            this.lblLogadouro.TabIndex = 12;
            this.lblLogadouro.Text = "label1";
            // 
            // FrmConsultaCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl);
            this.Name = "FrmConsultaCep";
            this.Size = new System.Drawing.Size(478, 403);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbllCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblLogadouro;
        private System.Windows.Forms.TextBox txtLogadouro;
    }
}
