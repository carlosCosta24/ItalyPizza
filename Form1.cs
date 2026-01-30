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
            static string[] Toppings = { };
        static void AddTopping(string Type) {
            
               
                    Toppings.Append(Type);
                
            
        }
        static void DeleteTopping(string Type)
        {
            string[] Temp = { };
            if(Toppings.Length != 0) { 
            
            for (byte i = 0; i <= Toppings.Length; i++)
            {
                if (Toppings[i] != Type)
                {
                    Temp.Append(Type);
                }
            }
            }
        }

        static string ShowTopping()
        {
            string ToppingList = " ";
            if (Toppings.Length == 0)
            {
                ToppingList = "No Toppings";
            }
            else
            {
                for (byte i = 0; i <= Toppings.Length; i++)
                {
                    ToppingList += Toppings[i] + ", ";
                }
            }
            return ToppingList;

        }
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
            if (ChkB4.Checked == true)
            {
                AddTopping("Onion");
                lb1.Text = ShowTopping();
                BasicPric += 5;
            }
            else {
                DeleteTopping(" Onion ");
                BasicPric -= 5;
                lb1.Text = ShowTopping();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkB5.Checked == true)
            {
                AddTopping("Olives");
                BasicPric += 5;
                label4.Text = ShowTopping();

            }
            else {
                AddTopping( " Olives ");
                BasicPric -= 5;
                label4.Text = ShowTopping();

            }
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

        private void ToppingsBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void ChkB1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkB1.Checked == true)
            {
                AddTopping("Extra chees");
                BasicPric += 5;
                label4.Text =  ShowTopping();
            }
            if(ChkB1.Checked == false) {
               DeleteTopping("Extra chees");
                BasicPric -= 5;
                label4.Text = ShowTopping();
            }
        }

        private void ChkB3_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkB3.Checked == true)
            {
                AddTopping("Mushrooms");
                BasicPric += 5;
                label4.Text = ShowTopping();
            }
            else {
                DeleteTopping(" Mushrooms");
                BasicPric -= 5;
                label4.Text = ShowTopping();

            }
        }

        private void ChkB5_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkB3.Checked == true)
            {
                AddTopping("Tomatoes");
                BasicPric += 5;
                label4.Text = ShowTopping();
            }
            else {
                DeleteTopping(" Tomatoes ");
                BasicPric -= 5;
                label4.Text = ShowTopping();

            }
        }

        private void ChkB6_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkB6.Checked == true)
            {
                AddTopping("Green pepers");
                BasicPric += 5;
                label4.Text = ShowTopping();
            }
            else {
                DeleteTopping(" Green pepers ");
                BasicPric -= 5;
                label4.Text = ShowTopping();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order",
                "Confirmation",
                MessageBoxButtons.
                OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK) {
                MessageBox.Show("Order Placed Successfuly",
                    "Success", 
                    MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                SizeBox.Enabled = false;
                CrustBox.Enabled = false;
                ToppingsBox.Enabled = false;    
                LocationBox.Enabled = false;
                btnOrder.Enabled = false;
            }
            ;
            

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            SizeBox.Enabled = true;
            CrustBox.Enabled = true;
            ToppingsBox.Enabled = true;
            LocationBox.Enabled = true;
            btnOrder.Enabled = true;
            ChkB1.Checked = false;
            ChkB2.Checked = false; 
            ChkB3.Checked = false; 
            ChkB4.Checked = false; 
            ChkB5.Checked = false;
            ChkB6.Checked = false;
            Rdb2.Checked = true;
            Rdb4.Checked = true;
            Rdb6.Checked = true;
            lb1.Text = "No Toppings";

        }
    }
}
