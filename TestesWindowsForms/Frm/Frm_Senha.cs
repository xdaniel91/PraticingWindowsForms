using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesWindowsForms
{
    public partial class Frm_Senha : UserControl
    {
        public Frm_Senha()
        {
            InitializeComponent();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Senha.UseSystemPasswordChar = false;
            Txt_Senha.PasswordChar = '*';
        }

        private void Cbx_VerSenha_CheckedChanged_1(object sender, EventArgs e)
        {
            Txt_Senha.PasswordChar = Cbx_VerSenha.Checked ? '\0' : '*';
        }
    }
}
