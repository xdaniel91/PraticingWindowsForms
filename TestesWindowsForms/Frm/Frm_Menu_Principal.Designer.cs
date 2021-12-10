
namespace TestesWindowsForms
{
    partial class Frm_Menu_Principal
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
            this.components = new System.ComponentModel.Container();
            this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.consultaCEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Principal
            // 
            this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem});
            this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Principal.Name = "Mnu_Principal";
            this.Mnu_Principal.Size = new System.Drawing.Size(628, 24);
            this.Mnu_Principal.TabIndex = 0;
            this.Mnu_Principal.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.senhaToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.consultaCEPToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // senhaToolStripMenuItem
            // 
            this.senhaToolStripMenuItem.Name = "senhaToolStripMenuItem";
            this.senhaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.senhaToolStripMenuItem.Text = "Senha";
            this.senhaToolStripMenuItem.Click += new System.EventHandler(this.senhaToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Tbc_Aplicacoes
            // 
            this.Tbc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Aplicacoes.Location = new System.Drawing.Point(0, 24);
            this.Tbc_Aplicacoes.Name = "Tbc_Aplicacoes";
            this.Tbc_Aplicacoes.SelectedIndex = 0;
            this.Tbc_Aplicacoes.Size = new System.Drawing.Size(628, 529);
            this.Tbc_Aplicacoes.TabIndex = 1;
            this.Tbc_Aplicacoes.SelectedIndexChanged += new System.EventHandler(this.Tbc_Aplicacoes_SelectedIndexChanged);
            // 
            // consultaCEPToolStripMenuItem
            // 
            this.consultaCEPToolStripMenuItem.Name = "consultaCEPToolStripMenuItem";
            this.consultaCEPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaCEPToolStripMenuItem.Text = "Consulta CEP";
            this.consultaCEPToolStripMenuItem.Click += new System.EventHandler(this.consultaCEPToolStripMenuItem_Click);
            // 
            // Frm_Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 553);
            this.Controls.Add(this.Tbc_Aplicacoes);
            this.Controls.Add(this.Mnu_Principal);
            this.MainMenuStrip = this.Mnu_Principal;
            this.Name = "Frm_Menu_Principal";
            this.Text = "Menu Principal";
            this.Mnu_Principal.ResumeLayout(false);
            this.Mnu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senhaToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl Tbc_Aplicacoes;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCEPToolStripMenuItem;
    }
}