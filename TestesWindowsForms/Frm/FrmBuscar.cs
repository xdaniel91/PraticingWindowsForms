using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesWindowsForms.Frm
{
    public partial class FrmBuscar : Form
    {
        List<List<string>> myListBi = new List<List<string>>();
        public string IdSelect { get; set; }

        public FrmBuscar(List<List<string>> listaBI)
        {
            myListBi = listaBI;
            InitializeComponent();
            this.Text = "Busca";
            stripPrincipal.Items[0].Text = "Mostrar";
            stripPrincipal.Items[1].Text = "Apagar";
            PreencherListBox();
            lstPrincipal.Sorted = true;
        }

        public void PreencherListBox()
        {
            lstPrincipal.Items.Clear();
            for (int i = 0; i <= myListBi.Count - 1; i++)
            {
                var itemBox = new ItemBox();
                itemBox.Id = myListBi[i][0];
                itemBox.Name = myListBi[i][1];
                lstPrincipal.Items.Add(itemBox);
            }
        }

        private void barBtnMostrar_Click(object sender, EventArgs e)
        { 
            // entender e fazer esse método


            DialogResult = DialogResult.OK;
            var itemSelecionado = new ItemBox();
            itemSelecionado = (ItemBox)lstPrincipal.Items[lstPrincipal.SelectedIndex];
            IdSelect = itemSelecionado.Id;
            this.Close();

        }

        private void barBtnApagar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lstPrincipal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            IdSelect = myListBi[lstPrincipal.SelectedIndex][0];
            this.Close();
        }

        class ItemBox
        {
            public string Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

    }
}
