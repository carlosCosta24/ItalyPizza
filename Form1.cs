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
        void UpdateSize() {

            UpdateTotalPrice();
            if (RdbSmall.Checked) {
                Size.Text = "Small";
                return;
            }
            if (RdbMedium.Checked) {
                Size.Text = "Medium";
                return;
            }
            if (RdbLarg.Checked) {

                Size.Text = "Large";
                return;
            }
        }
        void UpdateTotalPrice()
        {
            IbCost.Text = CalculateTotalPrice().ToString() + "$";
        }
        float CalculateTotalPrice() {

            return GetSizePrice() + GetToppingPrice() + GetCrustPrice();
        }
        float GetSizePrice()
        {

            if (RdbSmall.Checked)
            {
                return Convert.ToSingle(RdbSmall.Tag);
            }
            else if (RdbMedium.Checked)
            {
                return Convert.ToSingle(RdbMedium.Tag);
            }
            else { 
                return Convert.ToSingle(RdbLarg.Tag);
            }
        }
        float GetToppingPrice() { 
            float ToppingPrice = 0;

            if (ChkB1.Checked) { ToppingPrice += Convert.ToSingle(ChkB1.Tag); }
            if (ChkB2.Checked) { ToppingPrice += Convert.ToSingle(ChkB2.Tag); }
            if (ChkB3.Checked) { ToppingPrice += Convert.ToSingle(ChkB3.Tag); }
            if (ChkB4.Checked) { ToppingPrice += Convert.ToSingle(ChkB4.Tag); }
            if (ChkB5.Checked) { ToppingPrice += Convert.ToSingle(ChkB5.Tag); }
            if (ChkB6.Checked) { ToppingPrice += Convert.ToSingle(ChkB6.Tag); }
            return ToppingPrice;

        }
        float GetCrustPrice() {

            if (RdbThin.Checked) {
                return Convert.ToSingle(RdbThin.Tag);
            }
            else {
                return Convert.ToSingle(RdbThick.Tag);
            }
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (RdbThin.Checked)
            {

                Crust.Text = "Thin Crust";
                return;
            }
            if (RdbThick.Checked)
            {
                Crust.Text = "Thick Crust";
                return;
            }
        }
        void RestForm() {
            SizeBox.Enabled = true;
            CrustBox.Enabled = true;
            ToppingsBox.Enabled = true;
            LocationBox.Enabled = true;
            btnOrder.Enabled = true;
            RdbMedium.Checked = true;
            RdbThin.Checked = true;
            Rdb6.Checked = true;
            LbTopping.Text = "No Topping";
        }
        void UpdateToppings() {

            string Toppings = "";
            if (ChkB1.Checked) { Toppings = "Extra chess"; }
            if (ChkB2.Checked) { Toppings += ", Onion"; }
            if (ChkB3.Checked) { Toppings += ", Mashrooms"; }
            if (ChkB4.Checked) { Toppings += ", Olives"; }
            if (ChkB5.Checked) { Toppings += ", Tomatos"; }
            if (ChkB6.Checked) { Toppings += ", Green Pepers"; }
            if (Toppings.StartsWith(",")) { Toppings = Toppings.Substring(1, Toppings.Length - 1); }
            if (Toppings == "") { Toppings = "No Toppings"; }
            LbTopping.Text = Toppings;


        }
        void UpdateOrderSummary() {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateTotalPrice();
        
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
            UpdateOrderSummary();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
               Location.Text = "Take Out";
            
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
            UpdateSize();
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void Rdb2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Rdb3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Rdb5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Location.Text = "Eat In";
        }

        private void ToppingsBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void ChkB1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkB3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void ChkB5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void ChkB6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order",
                "Confirmation", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfuly", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                SizeBox.Enabled = false;
                CrustBox.Enabled = false;
                ToppingsBox.Enabled = false;
                LocationBox.Enabled = false;
                btnOrder.Enabled = false;
            }
            else {

                MessageBox.Show("Update your order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            RestForm();
        }

        private void SummaryBox_Enter(object sender, EventArgs e)
        {

        }

        private void Location_Click(object sender, EventArgs e)
        {

        }

        private void LbTopping_Click(object sender, EventArgs e)
        {

        }
    }
}
