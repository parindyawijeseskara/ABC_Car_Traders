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
            dataGridPlaceOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            panel1 = new Panel();
            txtTotal = new TextBox();
            label8 = new Label();
            button1 = new Button();
            txtDate = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridPlaceOrder).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPlaceOrder
            // 
            dataGridPlaceOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPlaceOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridPlaceOrder.Location = new Point(73, 442);
            dataGridPlaceOrder.Name = "dataGridPlaceOrder";
            dataGridPlaceOrder.RowHeadersWidth = 51;
            dataGridPlaceOrder.Size = new Size(1183, 205);
            dataGridPlaceOrder.TabIndex = 31;
            dataGridPlaceOrder.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Order Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Car / Part Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Order Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "View Details";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            Column6.Width = 130;
            // 
            // Column7
            // 
            Column7.HeaderText = "Cancel Order";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 130;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(201, 201, 201);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtDate);
            panel1.Controls.Add(txtContactNo);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(txtNic);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtQuantityOnHand);
            panel1.Controls.Add(txtUnitPrice);
            panel1.Controls.Add(txtBrand);
            panel1.Controls.Add(txtCarModel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCarRegNoOrPartName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(97, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1137, 315);
            panel1.TabIndex = 32;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(144, 288);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(187, 27);
            txtTotal.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 281);
            label8.Name = "label8";
            label8.Size = new Size(62, 22);
            label8.TabIndex = 59;
            label8.Text = "Total :";
            // 
            // button1
            // 
            button1.Location = new Point(942, 240);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 58;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(639, 242);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(187, 27);
            txtDate.TabIndex = 57;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(639, 190);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(187, 27);
            txtContactNo.TabIndex = 56;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(639, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 27);
            txtEmail.TabIndex = 55;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(639, 122);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(187, 27);
            txtAddress.TabIndex = 54;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(639, 76);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(187, 27);
            txtCustomerName.TabIndex = 53;
            // 
            // txtNic
            // 
            txtNic.Location = new Point(639, 28);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(187, 27);
            txtNic.TabIndex = 52;
            txtNic.KeyDown += txtNic_KeyDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(496, 247);
            label14.Name = "label14";
            label14.Size = new Size(53, 22);
            label14.TabIndex = 51;
            label14.Text = "Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(496, 195);
            label13.Name = "label13";
            label13.Size = new Size(105, 22);
            label13.TabIndex = 50;
            label13.Text = "Contact No:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(496, 158);
            label12.Name = "label12";
            label12.Size = new Size(63, 22);
            label12.TabIndex = 49;
            label12.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(496, 122);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 48;
            label11.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(496, 81);
            label10.Name = "label10";
            label10.Size = new Size(142, 22);
            label10.TabIndex = 47;
            label10.Text = "Customer Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(496, 33);
            label7.Name = "label7";
            label7.Size = new Size(125, 22);
            label7.TabIndex = 46;
            label7.Text = "Customer Nic:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(144, 247);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(187, 27);
            txtQuantity.TabIndex = 45;
            // 
            // txtQuantityOnHand
            // 
            txtQuantityOnHand.Location = new Point(189, 205);
            txtQuantityOnHand.Name = "txtQuantityOnHand";
            txtQuantityOnHand.Size = new Size(187, 27);
            txtQuantityOnHand.TabIndex = 44;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(144, 170);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(187, 27);
            txtUnitPrice.TabIndex = 43;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(144, 81);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(187, 27);
            txtBrand.TabIndex = 42;
            // 
            // txtCarModel
            // 
            txtCarModel.Location = new Point(144, 122);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(187, 27);
            txtCarModel.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 247);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 40;
            label6.Text = "Qunatity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 210);
            label5.Name = "label5";
            label5.Size = new Size(158, 22);
            label5.TabIndex = 39;
            label5.Text = "Quantity on Hand :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 172);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 38;
            label4.Text = "Unit Price :";
            // 
            // txtCarRegNoOrPartName
            // 
            txtCarRegNoOrPartName.Location = new Point(269, 28);
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
            label3.Location = new Point(28, 127);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 36;
            label3.Text = "Car Model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 33);
            label2.Name = "label2";
            label2.Size = new Size(238, 22);
            label2.TabIndex = 35;
            label2.Text = "Car RegNo / Car Part Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 86);
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
            label9.Size = new Size(159, 32);
            label9.TabIndex = 33;
            label9.Text = "Place Order";
            // 
            // CustomerDashboardMyOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1339, 689);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(dataGridPlaceOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashboardMyOrdersForm";
            Text = "CustomerDashboardMyOrdersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridPlaceOrder).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridPlaceOrder;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
        private Panel panel1;
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
        private TextBox txtDate;
        private TextBox txtContactNo;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtCustomerName;
        private TextBox txtNic;
        private Button button1;
        private Label label8;
        private TextBox txtTotal;
    }
}