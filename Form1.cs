using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItalyPizza
{
    public partial class Form1 : Form
    {
        int BasicPric = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void TxB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb7.Checked == true) {
                label5.Text = "Location: Out";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbCost_Click(object sender, EventArgs e)
        {

        }

        private void Rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb1.Checked == true)
            {

                Size.Text = "Size: S";
                IbCost.Text = $"{BasicPric + 10} $";

            }
            ;

        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb4.Checked == true) {

                label6.Text = "Crust Type: Tn";
            }
        }

        private void Rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb2.Checked == true)
            {

                Size.Text = "Size: M";
                IbCost.Text = $"{BasicPric + 20} $";

            }
            ;
        }

        private void Rdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb3.Checked == true)
            {

                Size.Text = "Size: L";
                IbCost.Text = $"{BasicPric + 30} $";

            }
            ;
        }

        private void Rdb5_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb5.Checked == true)
            {

                label6.Text = "Crust Type: Tk";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb6.Checked == true)
            {

                label5.Text = "Location: IN";
            }
        }
    }
}
