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
    public partial class Frm_Menu_Principal : Form
    {
        int tabControlSenha = 0;
        int tabControlCalculadora = 0;

        public Frm_Menu_Principal()
        {
            InitializeComponent();
        }

        private void senhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var senha = new Frm_Senha();
            var tabPage = new TabPage();
            tabPage.Name = "Senha";
            tabPage.Text = $"{tabControlSenha} - Senha";
            tabPage.Controls.Add(senha);

            Tbc_Aplicacoes.TabPages.Add(tabPage);

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calculadora = new Calculator();
            var tabPage = new TabPage();
            tabPage.Name = "Calculadora";
            tabPage.Text = $"{tabControlCalculadora} - Calculadora";
            tabPage.Controls.Add(calculadora);

            Tbc_Aplicacoes.TabPages.Add(tabPage);
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F = new Cadastro();
            var tabPage = new TabPage();
            tabPage.Name = "Cadastro";
            tabPage.Text = "Cadastro";
            tabPage.Controls.Add(F);
           
            Tbc_Aplicacoes.Controls.Add(tabPage);
        }

        private void Tbc_Aplicacoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void consultaCEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F = new FrmConsultaCep();
            var tabPage = new TabPage();
            tabPage.Name = "Consulta CEP";
            tabPage.Text = "Consulta CEP";
            tabPage.Controls.Add(F);

            Tbc_Aplicacoes.Controls.Add(tabPage);

        }
    }
}
