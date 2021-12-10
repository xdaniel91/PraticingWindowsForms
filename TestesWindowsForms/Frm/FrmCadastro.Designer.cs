
namespace TestesWindowsForms
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BtnEscrever = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "label1";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(12, 117);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(41, 15);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "label2";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "label3";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 196);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 15);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "label4";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 4;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(53, 117);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(85, 20);
            this.mskCpf.TabIndex = 5;
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(53, 196);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(85, 20);
            this.mskData.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(53, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.salvarToolStripButton,
            this.BtnEscrever});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(340, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(12, 40);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(19, 15);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(53, 37);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(49, 20);
            this.txt_id.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(121, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 20);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BtnEscrever
            // 
            this.BtnEscrever.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEscrever.Image = ((System.Drawing.Image)(resources.GetObject("BtnEscrever.Image")));
            this.BtnEscrever.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEscrever.Name = "BtnEscrever";
            this.BtnEscrever.Size = new System.Drawing.Size(23, 22);
            this.BtnEscrever.Text = "toolStripButton2";
            this.BtnEscrever.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Name = "Cadastro";
            this.Size = new System.Drawing.Size(340, 238);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripButton BtnEscrever;
    }
}
