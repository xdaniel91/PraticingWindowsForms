
namespace TestesWindowsForms
{
    partial class Frm_Senha
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
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Cbx_VerSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Limpar.Location = new System.Drawing.Point(218, 37);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 5;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(9, 37);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(194, 20);
            this.Txt_Senha.TabIndex = 4;
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // Cbx_VerSenha
            // 
            this.Cbx_VerSenha.AutoSize = true;
            this.Cbx_VerSenha.Location = new System.Drawing.Point(9, 63);
            this.Cbx_VerSenha.Name = "Cbx_VerSenha";
            this.Cbx_VerSenha.Size = new System.Drawing.Size(93, 17);
            this.Cbx_VerSenha.TabIndex = 3;
            this.Cbx_VerSenha.Text = "Mostrar senha";
            this.Cbx_VerSenha.UseVisualStyleBackColor = true;
            this.Cbx_VerSenha.CheckedChanged += new System.EventHandler(this.Cbx_VerSenha_CheckedChanged_1);
            // 
            // Frm_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Cbx_VerSenha);
            this.Name = "Frm_Senha";
            this.Size = new System.Drawing.Size(296, 115);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.CheckBox Cbx_VerSenha;
    }
}
