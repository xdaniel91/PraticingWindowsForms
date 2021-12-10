using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TestesWindowsForms
{
    public partial class Calculator : UserControl
    {
        decimal num1, num2;
        string op;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "9";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbl_num.Text))
            {
                return;
            }

            num1 = Convert.ToDecimal(lbl_num.Text, CultureInfo.InvariantCulture);
            lbl_num.Text = "";
            op = "soma";
            lbl_op.Text = "+";
            lbl_savenum1.Text = Convert.ToString(num1);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbl_num.Text))
            {
                return;
            }

            num1 = Convert.ToDecimal(lbl_num.Text, CultureInfo.InvariantCulture);
            lbl_num.Text = "";
            op = "sub";
            lbl_op.Text = "-";
           
            lbl_savenum1.Text = Convert.ToString(num1);
            
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbl_num.Text))
            {
                return;
            }

            num1 = Convert.ToDecimal(lbl_num.Text, CultureInfo.InvariantCulture);
            lbl_num.Text = "";
            op = "mult";
            lbl_op.Text = "*";
            lbl_savenum1.Text = Convert.ToString(num1);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbl_num.Text))
            {
                return;
            } 

            num1 = Convert.ToDecimal(lbl_num.Text, CultureInfo.InvariantCulture);
            lbl_num.Text = "";
            op = "div";
            lbl_op.Text = "/";
            lbl_savenum1.Text = Convert.ToString(num1);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbl_num.Text))
            {
                return;
            }
            if (String.IsNullOrEmpty(lbl_savenum1.Text))
            {
                return;
            }

            num2 = Convert.ToDecimal(lbl_num.Text, CultureInfo.InvariantCulture);
            lbl_savenum2.Text = Convert.ToString(num2);
            lbl_num.ForeColor = Color.DarkOliveGreen;


            if (op == "soma")
            {
                lbl_num.Text = Convert.ToString(num1 + num2);
            }
            else if (op == "mult")
            {
                lbl_num.Text = Convert.ToString(num1 * num2);
            }
            else if (op == "sub")
            {
                lbl_num.Text = Convert.ToString(num1 - num2);
            }
            else
            {
                if (num2 <= 0)
                {
                    return;
                }
                lbl_num.Text = Convert.ToString(num1 / num2);
            }

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lbl_savenum1.Text = "";
            lbl_savenum2.Text = "";
            lbl_op.Text = "";
            lbl_num.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            if (lbl_num.Text.Length <= 0)
            {
                return;
            }
            else
            {
                lbl_num.Text = lbl_num.Text.Remove(lbl_num.Text.Length - 1);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lbl_num.Text += ".";
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var ctxMenu = new ContextMenuStrip();
                var toolStrip = new ToolStripMenuItem();
                toolStrip.Text = "Limpar tudo";
                ctxMenu.Items.Add(toolStrip);
                ctxMenu.Show(this, e.Location);

                toolStrip.Click += new EventHandler(toolStrip_Click);
                Image MyImage = (Image)Properties.Resources.ResourceManager.GetObject("ClearAll");
                toolStrip.Image = MyImage;
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lbl_num.Text += "0";
        }

        private void toolStrip_Click(object sender, EventArgs e)
        {
            lbl_savenum1.Text = "";
            lbl_savenum2.Text = "";
            lbl_op.Text = "";
            lbl_num.Text = "";
        }
    }
}
