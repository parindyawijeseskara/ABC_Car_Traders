namespace ABC_Car_Traders
{
    partial class CustomerDashboardMyOrdersForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardMyOrdersForm));
            dataGridPlaceOrder = new DataGridView();
            txtDate = new DateTimePicker();
            txtTotal = new TextBox();
            label8 = new Label();
            button1 = new Button();
            txtContactNo = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtCustomerName = new TextBox();
            txtNic = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            txtQuantity = new TextBox();
            txtQuantityOnHand = new TextBox();
            txtUnitPrice = new TextBox();
            txtBrand = new TextBox();
            txtCarModel = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCarRegNoOrPartName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            btnSubmit = new Button();
            txtFinalTotal = new TextBox();
            label15 = new Label();
            label16 = new Label();
            pictureBox1 = new PictureBox();
            label17 = new Label();
            label18 = new Label();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridPlaceOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridPlaceOrder
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 115, 144);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridPlaceOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPlaceOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPlaceOrder.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column6, Column1, Column5 });
            dataGridPlaceOrder.EnableHeadersVisualStyles = false;
            dataGridPlaceOrder.Location = new Point(73, 442);
            dataGridPlaceOrder.Name = "dataGridPlaceOrder";
            dataGridPlaceOrder.RowHeadersWidth = 51;
            dataGridPlaceOrder.Size = new Size(1183, 147);
            dataGridPlaceOrder.TabIndex = 31;
            dataGridPlaceOrder.CellClick += dataGridView1_CellClick;
            dataGridPlaceOrder.CellContentClick += dataGridPlaceOrder_CellContentClick;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(844, 342);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(250, 27);
            txtDate.TabIndex = 62;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1139, 173);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(167, 27);
            txtTotal.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1071, 175);
            label8.Name = "label8";
            label8.Size = new Size(62, 22);
            label8.TabIndex = 59;
            label8.Text = "Total :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 115, 144);
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1135, 332);
            button1.Name = "button1";
            button1.Size = new Size(155, 44);
            button1.TabIndex = 58;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(894, 285);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(187, 27);
            txtContactNo.TabIndex = 56;
            txtContactNo.TextChanged += txtContactNo_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(540, 282);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 27);
            txtEmail.TabIndex = 55;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(559, 341);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(187, 27);
            txtAddress.TabIndex = 54;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(245, 337);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(187, 27);
            txtCustomerName.TabIndex = 53;
            // 
            // txtNic
            // 
            txtNic.Location = new Point(228, 282);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(187, 27);
            txtNic.TabIndex = 52;
            txtNic.KeyDown += txtNic_KeyDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(785, 346);
            label14.Name = "label14";
            label14.Size = new Size(53, 22);
            label14.TabIndex = 51;
            label14.Text = "Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(785, 290);
            label13.Name = "label13";
            label13.Size = new Size(105, 22);
            label13.TabIndex = 50;
            label13.Text = "Contact No:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(471, 287);
            label12.Name = "label12";
            label12.Size = new Size(63, 22);
            label12.TabIndex = 49;
            label12.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(471, 346);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 48;
            label11.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(97, 339);
            label10.Name = "label10";
            label10.Size = new Size(142, 22);
            label10.TabIndex = 47;
            label10.Text = "Customer Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(97, 287);
            label7.Name = "label7";
            label7.Size = new Size(125, 22);
            label7.TabIndex = 46;
            label7.Text = "Customer Nic:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(858, 170);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(187, 27);
            txtQuantity.TabIndex = 45;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtQuantityOnHand
            // 
            txtQuantityOnHand.Location = new Point(929, 117);
            txtQuantityOnHand.Name = "txtQuantityOnHand";
            txtQuantityOnHand.Size = new Size(187, 27);
            txtQuantityOnHand.TabIndex = 44;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(551, 165);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(187, 27);
            txtUnitPrice.TabIndex = 43;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(213, 165);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(187, 27);
            txtBrand.TabIndex = 42;
            // 
            // txtCarModel
            // 
            txtCarModel.Location = new Point(551, 117);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(187, 27);
            txtCarModel.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(765, 172);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 40;
            label6.Text = "Qunatity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(765, 122);
            label5.Name = "label5";
            label5.Size = new Size(158, 22);
            label5.TabIndex = 39;
            label5.Text = "Quantity on Hand :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(444, 170);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 38;
            label4.Text = "Unit Price :";
            // 
            // txtCarRegNoOrPartName
            // 
            txtCarRegNoOrPartName.Location = new Point(213, 112);
            txtCarRegNoOrPartName.Name = "txtCarRegNoOrPartName";
            txtCarRegNoOrPartName.Size = new Size(187, 27);
            txtCarRegNoOrPartName.TabIndex = 35;
            txtCarRegNoOrPartName.TextChanged += txtCarRegNoOrPartName_TextChanged;
            txtCarRegNoOrPartName.KeyDown += txtCarRegNoOrPartName_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(443, 119);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 36;
            label3.Text = "Car Model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 117);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 35;
            label2.Text = "Car RegNo :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 170);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 34;
            label1.Text = "Car Brand :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(35, 115, 144);
            label9.Location = new Point(53, 34);
            label9.Name = "label9";
            label9.Size = new Size(0, 32);
            label9.TabIndex = 33;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.RosyBrown;
            btnSubmit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1135, 611);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(99, 46);
            btnSubmit.TabIndex = 63;
            btnSubmit.Text = "Order";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtFinalTotal
            // 
            txtFinalTotal.Location = new Point(926, 630);
            txtFinalTotal.Name = "txtFinalTotal";
            txtFinalTotal.Size = new Size(187, 27);
            txtFinalTotal.TabIndex = 64;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(798, 634);
            label15.Name = "label15";
            label15.Size = new Size(101, 23);
            label15.TabIndex = 65;
            label15.Text = "Full Total :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(35, 115, 144);
            label16.Location = new Point(21, 75);
            label16.Name = "label16";
            label16.Size = new Size(1317, 20);
            label16.TabIndex = 68;
            label16.Text = resources.GetString("label16.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1139, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(35, 115, 144);
            label17.Location = new Point(97, 34);
            label17.Name = "label17";
            label17.Size = new Size(212, 32);
            label17.TabIndex = 66;
            label17.Text = "Car Order Form";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(97, 228);
            label18.Name = "label18";
            label18.Size = new Size(168, 23);
            label18.TabIndex = 69;
            label18.Text = "Customer Details :";
            // 
            // Column2
            // 
            Column2.HeaderText = "Car RegNo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Order Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 165;
            // 
            // Column6
            // 
            Column6.HeaderText = "Unit Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 165;
            // 
            // Column1
            // 
            Column1.HeaderText = "Price";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // CustomerDashboardMyOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1339, 689);
            Controls.Add(label18);
            Controls.Add(button1);
            Controls.Add(txtDate);
            Controls.Add(label16);
            Controls.Add(txtTotal);
            Controls.Add(label14);
            Controls.Add(txtContactNo);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(label17);
            Controls.Add(label12);
            Controls.Add(txtCustomerName);
            Controls.Add(btnSubmit);
            Controls.Add(txtNic);
            Controls.Add(label11);
            Controls.Add(txtFinalTotal);
            Controls.Add(label15);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(dataGridPlaceOrder);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(txtCarRegNoOrPartName);
            Controls.Add(label1);
            Controls.Add(txtBrand);
            Controls.Add(label3);
            Controls.Add(txtCarModel);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(txtQuantityOnHand);
            Controls.Add(txtUnitPrice);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashboardMyOrdersForm";
            Text = "CustomerDashboardMyOrdersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridPlaceOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridPlaceOrder;
        private Label label9;
        private Label label1;
        private TextBox txtCarRegNoOrPartName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtQuantity;
        private TextBox txtQuantityOnHand;
        private TextBox txtUnitPrice;
        private TextBox txtBrand;
        private TextBox txtCarModel;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtContactNo;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtCustomerName;
        private TextBox txtNic;
        private Button button1;
        private Label label8;
        private TextBox txtTotal;
        private DateTimePicker txtDate;
        private Button btnSubmit;
        private TextBox txtFinalTotal;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox1;
        private Label label17;
        private Label label18;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
    }
}