using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca.Database;
using WindowsFormsLibrary;
using TestesWindowsForms.Frm;


namespace TestesWindowsForms
{
    public partial class Cadastro : UserControl
    {
        string _directory = "C:\\Users\\DanielRodriguesCarva\\Documents\\TesteDataBase";

        public Cadastro()
        {
            InitializeComponent();
            lblCpf.Text = "CPF: ";
            lblNome.Text = "Nome: ";
            lblData.Text = "Data: ";
            lblEmail.Text = "E-mail";
            btnBuscar.Text = "Procurar";
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // incluir
        {
            Person.Unit C = new Person.Unit();
            C = LeituraFrm();
            string clientejson = Person.SerializerUnit(C);

            Connection connection = new Connection(_directory);
            if (connection.Status)
            {
                connection.Incluir(C.Id, clientejson);
                if (connection.Status)
                {
                    MessageBox.Show(connection.Mensagem, "Ok", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(connection.Mensagem, "Falhou", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(connection.Mensagem, "Falhou", MessageBoxButtons.OK);
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            var cliente = new Person.Unit();
            var connection = new Connection(_directory);
        }

        private Person.Unit LeituraFrm()
        {
            var psn = new Person.Unit();
            psn.Birth = Convert.ToDateTime(mskData.Text);
            psn.CPF = mskCpf.Text;
            psn.Email = txtEmail.Text;
            psn.Id = txt_id.Text;
            psn.Nome = txtNome.Text;
            return psn;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var connection = new Connection(_directory);
            var listJson = connection.BuscarTodos();
            if (connection.Status == true)
            {
                var listaBI = new List<List<string>>();
              
                for (int i = 0; i < listJson.Count; i++)
                {
                    var C = Person.DesSerializerUnit(listJson[i]);
                    listaBI.Add(new List<string> { C.Id, C.Nome });
                }

                var frm = new FrmBuscar(listaBI);
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    var clienteJson = connection.Buscar(frm.IdSelect);
                    var unit = Person.DesSerializerUnit(clienteJson);
                    EscreveFormulario(unit);
                }
            }
            else
            {
                MessageBox.Show($"Erro ao criar conexão {connection.Mensagem}", "ByteBank", MessageBoxButtons.OK);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Campo ID vazio", "ByteBank", MessageBoxButtons.OK);
            }
            else
            {
                var connection = new Connection(_directory);
                var jsontoDeserializer = connection.Buscar(txt_id.Text);
                if (connection.Status == true)
                {
                    var unit = Person.DesSerializerUnit(jsontoDeserializer);
                    EscreveFormulario(unit);
                }
                else
                {
                    MessageBox.Show($"Erro em connection {connection.Mensagem}", "ByteBank", MessageBoxButtons.OK);
                }
            }
        }

        void EscreveFormulario(Person.Unit C)
        {
            txt_id.Text = C.Id;
            txtNome.Text = C.Nome;
            mskCpf.Text = C.CPF;
            txtEmail.Text = C.Email;
            mskData.Text = C.Birth.ToString();
        }

    }
}
