using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using WindowsFormsLibrary;



namespace TestesWindowsForms
{
    public partial class FrmConsultaCep : UserControl
    {
        public FrmConsultaCep()
        {
            InitializeComponent();
            lblBairro.Text = "Bairro";
            lblCEP.Text = "CEP";
            lblEstado.Text = "Estado";
            lbllCidade.Text = "Cidade";
            lblLogadouro.Text = "Logadouro";

            btnBuscar.Text = "Buscar";
            btnLimpar.Text = "Limpar";
           

            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtLogadouro.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cep = txtCEP.Text;
            cep.Replace("-", String.Empty);
            cep = cep.Trim();

            if (!String.IsNullOrEmpty(cep) && Information.IsNumeric(cep) == true && cep.Length == 8)
            {
                var vJson = Utils.GeradorCEP(cep); // busca o CEP e gera o Json

                var CEP = new Cep.CepUnit(); // ref de Cep.Unit
                CEP = Cep.JsonParaClass(vJson); // armazena os dados da Json nas propiedades da ref de Cep.Unit

                txtBairro.Text = CEP.Bairro;
                txtLogadouro.Text = CEP.Logradouro;
                txtCidade.Text = CEP.Localidade;
                txtEstado.Text = CEP.UF;

            }
            else
            {
                return;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtLogadouro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCEP.Text = "";
        }


    }
}
