namespace ABC_Car_Traders
{
    partial class CustomerDashboardCarPartsOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardCarPartsOrderForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridPlaceOrder = new DataGridView();
            label2 = new Label();
            cmbCarBrand = new ComboBox();
            label3 = new Label();
            cmbCarModel = new ComboBox();
            txtDate = new DateTimePicker();
            txtTotal = new TextBox();
            label8 = new Label();
            btnPlaceOrder = new Button();
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label15 = new Label();
            label16 = new Label();
            cmbCarPartName = new ComboBox();
            btnSubmit = new Button();
            txtFinalTotal = new TextBox();
            label17 = new Label();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPlaceOrder).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(35, 115, 144);
            label9.Location = new Point(79, 40);
            label9.Name = "label9";
            label9.Size = new Size(272, 32);
            label9.TabIndex = 34;
            label9.Text = "Car Part Order Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1121, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(35, 115, 144);
            label1.Location = new Point(3, 81);
            label1.Name = "label1";
            label1.Size = new Size(1317, 20);
            label1.TabIndex = 36;
            label1.Text = resources.GetString("label1.Text");
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
            dataGridPlaceOrder.Location = new Point(73, 497);
            dataGridPlaceOrder.Name = "dataGridPlaceOrder";
            dataGridPlaceOrder.RowHeadersWidth = 51;
            dataGridPlaceOrder.Size = new Size(1182, 128);
            dataGridPlaceOrder.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 164);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 38;
            label2.Text = "Car Brand";
            // 
            // cmbCarBrand
            // 
            cmbCarBrand.FormattingEnabled = true;
            cmbCarBrand.Location = new Point(200, 158);
            cmbCarBrand.Name = "cmbCarBrand";
            cmbCarBrand.Size = new Size(171, 28);
            cmbCarBrand.TabIndex = 39;
            cmbCarBrand.SelectedValueChanged += cmbCarBrand_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 223);
            label3.Name = "label3";
            label3.Size = new Size(96, 22);
            label3.TabIndex = 40;
            label3.Text = "Car Model";
            // 
            // cmbCarModel
            // 
            cmbCarModel.FormattingEnabled = true;
            cmbCarModel.Location = new Point(200, 217);
            cmbCarModel.Name = "cmbCarModel";
            cmbCarModel.Size = new Size(171, 28);
            cmbCarModel.TabIndex = 41;
            cmbCarModel.SelectedValueChanged += cmbCarModel_SelectedIndexChanged;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(847, 411);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(250, 27);
            txtDate.TabIndex = 62;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1118, 217);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(187, 27);
            txtTotal.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1050, 223);
            label8.Name = "label8";
            label8.Size = new Size(62, 22);
            label8.TabIndex = 59;
            label8.Text = "Total :";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(35, 115, 144);
            btnPlaceOrder.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(1133, 394);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(155, 44);
            btnPlaceOrder.TabIndex = 58;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(899, 346);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(187, 27);
            txtContactNo.TabIndex = 56;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(543, 408);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 27);
            txtEmail.TabIndex = 55;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(543, 343);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(187, 27);
            txtAddress.TabIndex = 54;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(227, 406);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(187, 27);
            txtCustomerName.TabIndex = 53;
            // 
            // txtNic
            // 
            txtNic.Location = new Point(210, 338);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(187, 27);
            txtNic.TabIndex = 52;
            txtNic.KeyDown += txtNic_KeyDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(788, 411);
            label14.Name = "label14";
            label14.Size = new Size(53, 22);
            label14.TabIndex = 51;
            label14.Text = "Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(788, 348);
            label13.Name = "label13";
            label13.Size = new Size(105, 22);
            label13.TabIndex = 50;
            label13.Text = "Contact No:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(455, 411);
            label12.Name = "label12";
            label12.Size = new Size(63, 22);
            label12.TabIndex = 49;
            label12.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(455, 343);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 48;
            label11.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(79, 408);
            label10.Name = "label10";
            label10.Size = new Size(142, 22);
            label10.TabIndex = 47;
            label10.Text = "Customer Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(79, 338);
            label7.Name = "label7";
            label7.Size = new Size(125, 22);
            label7.TabIndex = 46;
            label7.Text = "Customer Nic:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(847, 218);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(187, 27);
            txtQuantity.TabIndex = 45;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtQuantityOnHand
            // 
            txtQuantityOnHand.Location = new Point(941, 159);
            txtQuantityOnHand.Name = "txtQuantityOnHand";
            txtQuantityOnHand.Size = new Size(187, 27);
            txtQuantityOnHand.TabIndex = 44;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(532, 217);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(187, 27);
            txtUnitPrice.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(764, 223);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 40;
            label6.Text = "Qunatity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(777, 164);
            label5.Name = "label5";
            label5.Size = new Size(158, 22);
            label5.TabIndex = 39;
            label5.Text = "Quantity on Hand :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(425, 223);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 38;
            label4.Text = "Unit Price :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(79, 282);
            label15.Name = "label15";
            label15.Size = new Size(168, 23);
            label15.TabIndex = 63;
            label15.Text = "Customer Details :";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(425, 164);
            label16.Name = "label16";
            label16.Size = new Size(138, 22);
            label16.TabIndex = 64;
            label16.Text = "Car Part Name :";
            // 
            // cmbCarPartName
            // 
            cmbCarPartName.FormattingEnabled = true;
            cmbCarPartName.Location = new Point(569, 162);
            cmbCarPartName.Name = "cmbCarPartName";
            cmbCarPartName.Size = new Size(171, 28);
            cmbCarPartName.TabIndex = 65;
            cmbCarPartName.SelectedValueChanged += cmbCarPartName_SelectedIndexChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.RosyBrown;
            btnSubmit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1165, 631);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(99, 46);
            btnSubmit.TabIndex = 66;
            btnSubmit.Text = "Order";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtFinalTotal
            // 
            txtFinalTotal.Location = new Point(956, 650);
            txtFinalTotal.Name = "txtFinalTotal";
            txtFinalTotal.Size = new Size(187, 27);
            txtFinalTotal.TabIndex = 67;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(828, 654);
            label17.Name = "label17";
            label17.Size = new Size(101, 23);
            label17.TabIndex = 68;
            label17.Text = "Full Total :";
            // 
            // Column2
            // 
            Column2.HeaderText = "Car Part Name";
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
            Column6.DataPropertyName = "unitPrice";
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
            // CustomerDashboardCarPartsOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1339, 689);
            Controls.Add(btnSubmit);
            Controls.Add(txtFinalTotal);
            Controls.Add(label17);
            Controls.Add(cmbCarPartName);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(btnPlaceOrder);
            Controls.Add(txtDate);
            Controls.Add(txtTotal);
            Controls.Add(txtContactNo);
            Controls.Add(label14);
            Controls.Add(cmbCarModel);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(label13);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtCustomerName);
            Controls.Add(label12);
            Controls.Add(cmbCarBrand);
            Controls.Add(txtNic);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(dataGridPlaceOrder);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(txtQuantityOnHand);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtUnitPrice);
            Controls.Add(label6);
            Controls.Add(txtQuantity);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashboardCarPartsOrderForm";
            Text = "CustomerDashboardCarOrderForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPlaceOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridPlaceOrder;
        private Label label2;
        private ComboBox cmbCarBrand;
        private Label label3;
        private ComboBox cmbCarModel;
        private DateTimePicker txtDate;
        private Button btnPlaceOrder;
        private TextBox txtContactNo;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtTotal;
        private Label label8;
        private TextBox txtCustomerName;
        private TextBox txtNic;
        private Label label7;
        private TextBox txtQuantity;
        private TextBox txtQuantityOnHand;
        private TextBox txtUnitPrice;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label15;
        private Label label16;
        private ComboBox cmbCarPartName;
        private Button btnSubmit;
        private TextBox txtFinalTotal;
        private Label label17;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
    }
}