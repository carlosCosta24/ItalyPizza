namespace ItalyPizza
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SizeBox = new System.Windows.Forms.GroupBox();
            this.RdbLarg = new System.Windows.Forms.RadioButton();
            this.RdbMedium = new System.Windows.Forms.RadioButton();
            this.RdbSmall = new System.Windows.Forms.RadioButton();
            this.CrustBox = new System.Windows.Forms.GroupBox();
            this.RdbThick = new System.Windows.Forms.RadioButton();
            this.RdbThin = new System.Windows.Forms.RadioButton();
            this.ToppingsBox = new System.Windows.Forms.GroupBox();
            this.ChkB3 = new System.Windows.Forms.CheckBox();
            this.ChkB6 = new System.Windows.Forms.CheckBox();
            this.ChkB2 = new System.Windows.Forms.CheckBox();
            this.ChkB5 = new System.Windows.Forms.CheckBox();
            this.ChkB4 = new System.Windows.Forms.CheckBox();
            this.ChkB1 = new System.Windows.Forms.CheckBox();
            this.LocationBox = new System.Windows.Forms.GroupBox();
            this.Rdb7 = new System.Windows.Forms.RadioButton();
            this.Rdb6 = new System.Windows.Forms.RadioButton();
            this.SummaryBox = new System.Windows.Forms.GroupBox();
            this.Crust = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbCrust = new System.Windows.Forms.Label();
            this.Topping = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbLoc = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.IbCost = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LbTopping = new System.Windows.Forms.Label();
            this.SizeBox.SuspendLayout();
            this.CrustBox.SuspendLayout();
            this.ToppingsBox.SuspendLayout();
            this.LocationBox.SuspendLayout();
            this.SummaryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // SizeBox
            // 
            this.SizeBox.BackColor = System.Drawing.SystemColors.Control;
            this.SizeBox.Controls.Add(this.RdbLarg);
            this.SizeBox.Controls.Add(this.RdbMedium);
            this.SizeBox.Controls.Add(this.RdbSmall);
            this.SizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeBox.ForeColor = System.Drawing.Color.Red;
            this.SizeBox.Location = new System.Drawing.Point(49, 118);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(170, 130);
            this.SizeBox.TabIndex = 3;
            this.SizeBox.TabStop = false;
            this.SizeBox.Text = "Size";
            this.SizeBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RdbLarg
            // 
            this.RdbLarg.AutoSize = true;
            this.RdbLarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbLarg.Location = new System.Drawing.Point(6, 89);
            this.RdbLarg.Name = "RdbLarg";
            this.RdbLarg.Size = new System.Drawing.Size(64, 24);
            this.RdbLarg.TabIndex = 2;
            this.RdbLarg.Tag = "40";
            this.RdbLarg.Text = "Larg";
            this.RdbLarg.UseVisualStyleBackColor = true;
            this.RdbLarg.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // RdbMedium
            // 
            this.RdbMedium.AutoSize = true;
            this.RdbMedium.Checked = true;
            this.RdbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbMedium.Location = new System.Drawing.Point(6, 63);
            this.RdbMedium.Name = "RdbMedium";
            this.RdbMedium.Size = new System.Drawing.Size(89, 24);
            this.RdbMedium.TabIndex = 1;
            this.RdbMedium.TabStop = true;
            this.RdbMedium.Tag = "30";
            this.RdbMedium.Text = "Medium";
            this.RdbMedium.UseVisualStyleBackColor = true;
            this.RdbMedium.CheckedChanged += new System.EventHandler(this.Rdb2_CheckedChanged);
            // 
            // RdbSmall
            // 
            this.RdbSmall.AutoSize = true;
            this.RdbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbSmall.Location = new System.Drawing.Point(6, 37);
            this.RdbSmall.Name = "RdbSmall";
            this.RdbSmall.Size = new System.Drawing.Size(72, 24);
            this.RdbSmall.TabIndex = 0;
            this.RdbSmall.Tag = "20";
            this.RdbSmall.Text = "Small";
            this.RdbSmall.UseVisualStyleBackColor = true;
            this.RdbSmall.CheckedChanged += new System.EventHandler(this.Rdb1_CheckedChanged);
            // 
            // CrustBox
            // 
            this.CrustBox.BackColor = System.Drawing.SystemColors.Control;
            this.CrustBox.Controls.Add(this.RdbThick);
            this.CrustBox.Controls.Add(this.RdbThin);
            this.CrustBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrustBox.ForeColor = System.Drawing.Color.Red;
            this.CrustBox.Location = new System.Drawing.Point(49, 277);
            this.CrustBox.Name = "CrustBox";
            this.CrustBox.Size = new System.Drawing.Size(139, 130);
            this.CrustBox.TabIndex = 4;
            this.CrustBox.TabStop = false;
            this.CrustBox.Text = "Crust";
            // 
            // RdbThick
            // 
            this.RdbThick.AutoSize = true;
            this.RdbThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbThick.Location = new System.Drawing.Point(22, 78);
            this.RdbThick.Name = "RdbThick";
            this.RdbThick.Size = new System.Drawing.Size(70, 24);
            this.RdbThick.TabIndex = 6;
            this.RdbThick.Tag = "10";
            this.RdbThick.Text = "Thick";
            this.RdbThick.UseVisualStyleBackColor = true;
            this.RdbThick.CheckedChanged += new System.EventHandler(this.Rdb5_CheckedChanged);
            // 
            // RdbThin
            // 
            this.RdbThin.AutoSize = true;
            this.RdbThin.Checked = true;
            this.RdbThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbThin.Location = new System.Drawing.Point(22, 38);
            this.RdbThin.Name = "RdbThin";
            this.RdbThin.Size = new System.Drawing.Size(62, 24);
            this.RdbThin.TabIndex = 5;
            this.RdbThin.TabStop = true;
            this.RdbThin.Tag = "0";
            this.RdbThin.Text = "Thin";
            this.RdbThin.UseVisualStyleBackColor = true;
            this.RdbThin.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // ToppingsBox
            // 
            this.ToppingsBox.BackColor = System.Drawing.SystemColors.Control;
            this.ToppingsBox.Controls.Add(this.ChkB3);
            this.ToppingsBox.Controls.Add(this.ChkB6);
            this.ToppingsBox.Controls.Add(this.ChkB2);
            this.ToppingsBox.Controls.Add(this.ChkB5);
            this.ToppingsBox.Controls.Add(this.ChkB4);
            this.ToppingsBox.Controls.Add(this.ChkB1);
            this.ToppingsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingsBox.ForeColor = System.Drawing.Color.Red;
            this.ToppingsBox.Location = new System.Drawing.Point(238, 118);
            this.ToppingsBox.Name = "ToppingsBox";
            this.ToppingsBox.Size = new System.Drawing.Size(420, 130);
            this.ToppingsBox.TabIndex = 5;
            this.ToppingsBox.TabStop = false;
            this.ToppingsBox.Text = "Toppings";
            this.ToppingsBox.Enter += new System.EventHandler(this.ToppingsBox_Enter);
            // 
            // ChkB3
            // 
            this.ChkB3.AutoSize = true;
            this.ChkB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkB3.Location = new System.Drawing.Point(24, 63);
            this.ChkB3.Name = "ChkB3";
            this.ChkB3.Size = new System.Drawing.Size(119, 24);
            this.ChkB3.TabIndex = 5;
            this.ChkB3.Tag = "5";
            this.ChkB3.Text = "Mushrooms";
            this.ChkB3.UseVisualStyleBackColor = true;
            this.ChkB3.CheckedChanged += new System.EventHandler(this.ChkB3_CheckedChanged);
            // 
            // ChkB6
            // 
            this.ChkB6.AutoSize = true;
            this.ChkB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkB6.Location = new System.Drawing.Point(239, 91);
            this.ChkB6.Name = "ChkB6";
            this.ChkB6.Size = new System.Drawing.Size(135, 24);
            this.ChkB6.TabIndex = 4;
            this.ChkB6.Tag = "5";
            this.ChkB6.Text = "Green Pepers";
            this.ChkB6.UseVisualStyleBackColor = true;
            this.ChkB6.CheckedChanged += new System.EventHandler(this.ChkB6_CheckedChanged);
            // 
            // ChkB2
            // 
            this.ChkB2.AutoSize = true;
            this.ChkB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkB2.Location = new System.Drawing.Point(239, 33);
            this.ChkB2.Name = "ChkB2";
            this.ChkB2.Size = new System.Drawing.Size(75, 24);
            this.ChkB2.TabIndex = 3;
            this.ChkB2.Tag = "5";
            this.ChkB2.Text = "Onion";
            this.ChkB2.UseVisualStyleBackColor = true;
            this.ChkB2.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ChkB5
            // 
            this.ChkB5.AutoSize = true;
            this.ChkB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkB5.Location = new System.Drawing.Point(24, 89);
            this.ChkB5.Name = "ChkB5";
            this.ChkB5.Size = new System.Drawing.Size(105, 24);
            this.ChkB5.TabIndex = 2;
            this.ChkB5.Tag = "5";
            this.ChkB5.Text = "Tomatoes";
            this.ChkB5.UseVisualStyleBackColor = true;
            this.ChkB5.CheckedChanged += new System.EventHandler(this.ChkB5_CheckedChanged);
            // 
            // ChkB4
            // 
            this.ChkB4.AutoSize = true;
            this.ChkB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkB4.Location = new System.Drawing.Point(239, 61);
            this.ChkB4.Name = "ChkB4";
            this.ChkB4.Size = new System.Drawing.Size(78, 24);
            this.ChkB4.TabIndex = 1;
            this.ChkB4.Tag = "5";
            this.ChkB4.Text = "Olives";
            this.ChkB4.UseVisualStyleBackColor = true;
            this.ChkB4.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ChkB1
            // 
            this.ChkB1.AutoSize = true;
            this.ChkB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkB1.Location = new System.Drawing.Point(24, 37);
            this.ChkB1.Name = "ChkB1";
            this.ChkB1.Size = new System.Drawing.Size(123, 24);
            this.ChkB1.TabIndex = 0;
            this.ChkB1.Tag = "5";
            this.ChkB1.Text = "Extra Chees";
            this.ChkB1.UseVisualStyleBackColor = true;
            this.ChkB1.CheckedChanged += new System.EventHandler(this.ChkB1_CheckedChanged);
            // 
            // LocationBox
            // 
            this.LocationBox.BackColor = System.Drawing.SystemColors.Control;
            this.LocationBox.Controls.Add(this.Rdb7);
            this.LocationBox.Controls.Add(this.Rdb6);
            this.LocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationBox.ForeColor = System.Drawing.Color.Red;
            this.LocationBox.Location = new System.Drawing.Point(304, 277);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(218, 130);
            this.LocationBox.TabIndex = 6;
            this.LocationBox.TabStop = false;
            this.LocationBox.Text = "Where To Eat";
            // 
            // Rdb7
            // 
            this.Rdb7.AutoSize = true;
            this.Rdb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb7.Location = new System.Drawing.Point(23, 78);
            this.Rdb7.Name = "Rdb7";
            this.Rdb7.Size = new System.Drawing.Size(94, 24);
            this.Rdb7.TabIndex = 4;
            this.Rdb7.Text = "Take out";
            this.Rdb7.UseVisualStyleBackColor = true;
            this.Rdb7.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Rdb6
            // 
            this.Rdb6.AutoSize = true;
            this.Rdb6.Checked = true;
            this.Rdb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb6.Location = new System.Drawing.Point(23, 48);
            this.Rdb6.Name = "Rdb6";
            this.Rdb6.Size = new System.Drawing.Size(83, 24);
            this.Rdb6.TabIndex = 3;
            this.Rdb6.TabStop = true;
            this.Rdb6.Text = "Dine in";
            this.Rdb6.UseVisualStyleBackColor = true;
            this.Rdb6.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // SummaryBox
            // 
            this.SummaryBox.BackColor = System.Drawing.SystemColors.Control;
            this.SummaryBox.Controls.Add(this.LbTopping);
            this.SummaryBox.Controls.Add(this.Crust);
            this.SummaryBox.Controls.Add(this.Location);
            this.SummaryBox.Controls.Add(this.Size);
            this.SummaryBox.Controls.Add(this.lb1);
            this.SummaryBox.Controls.Add(this.lbCrust);
            this.SummaryBox.Controls.Add(this.Topping);
            this.SummaryBox.Controls.Add(this.lbSize);
            this.SummaryBox.Controls.Add(this.lbLoc);
            this.SummaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryBox.ForeColor = System.Drawing.Color.Red;
            this.SummaryBox.Location = new System.Drawing.Point(687, 118);
            this.SummaryBox.Name = "SummaryBox";
            this.SummaryBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SummaryBox.Size = new System.Drawing.Size(569, 163);
            this.SummaryBox.TabIndex = 7;
            this.SummaryBox.TabStop = false;
            this.SummaryBox.Text = "Order Summary";
            this.SummaryBox.Enter += new System.EventHandler(this.SummaryBox_Enter);
            // 
            // Crust
            // 
            this.Crust.AutoSize = true;
            this.Crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crust.Location = new System.Drawing.Point(124, 130);
            this.Crust.Name = "Crust";
            this.Crust.Size = new System.Drawing.Size(109, 25);
            this.Crust.TabIndex = 9;
            this.Crust.Text = "Thin Crust";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.Location = new System.Drawing.Point(320, 130);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(25, 20);
            this.Location.TabIndex = 8;
            this.Location.Text = "IN";
            this.Location.Click += new System.EventHandler(this.Location_Click);
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.Location = new System.Drawing.Point(75, 48);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(73, 22);
            this.Size.TabIndex = 5;
            this.Size.Text = "Meduim";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(192, 76);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 32);
            this.lb1.TabIndex = 4;
            // 
            // lbCrust
            // 
            this.lbCrust.AutoSize = true;
            this.lbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrust.Location = new System.Drawing.Point(22, 128);
            this.lbCrust.Name = "lbCrust";
            this.lbCrust.Size = new System.Drawing.Size(96, 20);
            this.lbCrust.TabIndex = 3;
            this.lbCrust.Text = "Crust Type:";
            // 
            // Topping
            // 
            this.Topping.AutoSize = true;
            this.Topping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topping.Location = new System.Drawing.Point(181, 50);
            this.Topping.Name = "Topping";
            this.Topping.Size = new System.Drawing.Size(82, 20);
            this.Topping.TabIndex = 1;
            this.Topping.Text = "Toppings:";
            this.Topping.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(22, 48);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(47, 20);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Size:";
            // 
            // lbLoc
            // 
            this.lbLoc.AutoSize = true;
            this.lbLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoc.Location = new System.Drawing.Point(234, 129);
            this.lbLoc.Name = "lbLoc";
            this.lbLoc.Size = new System.Drawing.Size(78, 20);
            this.lbLoc.TabIndex = 2;
            this.lbLoc.Text = "Location:";
            this.lbLoc.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Green;
            this.lbPrice.Location = new System.Drawing.Point(677, 324);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(253, 55);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Total Price:";
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // IbCost
            // 
            this.IbCost.AutoSize = true;
            this.IbCost.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbCost.ForeColor = System.Drawing.Color.Green;
            this.IbCost.Location = new System.Drawing.Point(939, 329);
            this.IbCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IbCost.Name = "IbCost";
            this.IbCost.Size = new System.Drawing.Size(110, 55);
            this.IbCost.TabIndex = 10;
            this.IbCost.Tag = "0";
            this.IbCost.Text = " 0 $";
            this.IbCost.Click += new System.EventHandler(this.lbCost_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(358, 413);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(116, 52);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Oreder";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRest
            // 
            this.btnRest.AutoSize = true;
            this.btnRest.Location = new System.Drawing.Point(687, 413);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(145, 65);
            this.btnRest.TabIndex = 12;
            this.btnRest.Text = "Reset";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Peru;
            this.label7.Location = new System.Drawing.Point(399, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 54);
            this.label7.TabIndex = 13;
            this.label7.Text = "Italian Pizza ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LbTopping
            // 
            this.LbTopping.AutoEllipsis = true;
            this.LbTopping.AutoSize = true;
            this.LbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbTopping.Location = new System.Drawing.Point(266, 50);
            this.LbTopping.MaximumSize = new System.Drawing.Size(300, 50);
            this.LbTopping.MinimumSize = new System.Drawing.Size(100, 25);
            this.LbTopping.Name = "LbTopping";
            this.LbTopping.Size = new System.Drawing.Size(125, 31);
            this.LbTopping.TabIndex = 10;
            this.LbTopping.Text = "No Topping";
            this.LbTopping.Click += new System.EventHandler(this.LbTopping_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 517);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.IbCost);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.SummaryBox);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.ToppingsBox);
            this.Controls.Add(this.CrustBox);
            this.Controls.Add(this.SizeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeBox.ResumeLayout(false);
            this.SizeBox.PerformLayout();
            this.CrustBox.ResumeLayout(false);
            this.CrustBox.PerformLayout();
            this.ToppingsBox.ResumeLayout(false);
            this.ToppingsBox.PerformLayout();
            this.LocationBox.ResumeLayout(false);
            this.LocationBox.PerformLayout();
            this.SummaryBox.ResumeLayout(false);
            this.SummaryBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.GroupBox SizeBox;
        private System.Windows.Forms.GroupBox CrustBox;
        private System.Windows.Forms.GroupBox ToppingsBox;
        private System.Windows.Forms.GroupBox LocationBox;
        private System.Windows.Forms.GroupBox SummaryBox;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label IbCost;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.RadioButton RdbSmall;
        private System.Windows.Forms.RadioButton RdbLarg;
        private System.Windows.Forms.RadioButton RdbMedium;
        private System.Windows.Forms.CheckBox ChkB3;
        private System.Windows.Forms.CheckBox ChkB6;
        private System.Windows.Forms.CheckBox ChkB2;
        private System.Windows.Forms.CheckBox ChkB5;
        private System.Windows.Forms.CheckBox ChkB4;
        private System.Windows.Forms.CheckBox ChkB1;
        private System.Windows.Forms.Label lbCrust;
        private System.Windows.Forms.Label lbLoc;
        private System.Windows.Forms.Label Topping;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Rdb7;
        private System.Windows.Forms.RadioButton Rdb6;
        private System.Windows.Forms.RadioButton RdbThick;
        private System.Windows.Forms.RadioButton RdbThin;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.Label Crust;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label LbTopping;
    }
}

