namespace ABC_Car_Traders
{
    partial class ManageCustomerOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomerOrderForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            orderDetailsGird = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            panel2 = new Panel();
            txtCustomerName = new TextBox();
            btnSearchCustomer = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            btnRefresh = new Button();
            btnSearchByDateRange = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsGird).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 115, 144);
            label1.Location = new Point(72, 58);
            label1.Name = "label1";
            label1.Size = new Size(401, 32);
            label1.TabIndex = 8;
            label1.Text = "Manage Customer Order Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(585, 394);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(598, 269);
            label3.Name = "label3";
            label3.Size = new Size(234, 23);
            label3.TabIndex = 14;
            label3.Text = "Search by Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(597, 323);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 15;
            label4.Text = "Date From";
            // 
            // orderDetailsGird
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 115, 144);
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            orderDetailsGird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            orderDetailsGird.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailsGird.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column10, Column8, Column3, Column4, Column9, Column6, Column7, Column5 });
            orderDetailsGird.EnableHeadersVisualStyles = false;
            orderDetailsGird.Location = new Point(93, 491);
            orderDetailsGird.Name = "orderDetailsGird";
            orderDetailsGird.RowHeadersWidth = 51;
            orderDetailsGird.Size = new Size(1199, 235);
            orderDetailsGird.TabIndex = 16;
            orderDetailsGird.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "orderId";
            Column1.HeaderText = "Order Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "firstName";
            Column2.HeaderText = "Customer Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "nic";
            Column10.HeaderText = "Customer Nic";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "modelName";
            Column8.HeaderText = "Model";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "regNo";
            Column3.HeaderText = "Ordered Cars";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "carPartName";
            Column4.HeaderText = "Ordered Car Parts";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "qty";
            Column9.HeaderText = "Ordered Quantity";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "orderDate";
            Column6.HeaderText = "Order Date";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "status";
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Teal;
            Column5.DefaultCellStyle = dataGridViewCellStyle4;
            Column5.HeaderText = "View";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Text = "View";
            Column5.Width = 150;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 115, 144);
            panel2.Controls.Add(txtCustomerName);
            panel2.Location = new Point(838, 246);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 3);
            panel2.Size = new Size(215, 46);
            panel2.TabIndex = 19;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Dock = DockStyle.Fill;
            txtCustomerName.Location = new Point(0, 0);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(215, 43);
            txtCustomerName.TabIndex = 1;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchCustomer.FlatAppearance.BorderSize = 0;
            btnSearchCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchCustomer.ForeColor = SystemColors.ControlLightLight;
            btnSearchCustomer.Location = new Point(1086, 250);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(174, 42);
            btnSearchCustomer.TabIndex = 20;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            btnSearchCustomer.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(703, 319);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(203, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(929, 322);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 22;
            label5.Text = "Date To";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1032, 318);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(215, 27);
            dateTimePicker2.TabIndex = 23;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(35, 115, 144);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(1086, 376);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(174, 42);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += button3_Click;
            // 
            // btnSearchByDateRange
            // 
            btnSearchByDateRange.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchByDateRange.FlatAppearance.BorderSize = 0;
            btnSearchByDateRange.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchByDateRange.ForeColor = SystemColors.ControlLightLight;
            btnSearchByDateRange.Location = new Point(894, 376);
            btnSearchByDateRange.Name = "btnSearchByDateRange";
            btnSearchByDateRange.Size = new Size(174, 42);
            btnSearchByDateRange.TabIndex = 26;
            btnSearchByDateRange.Text = "Search";
            btnSearchByDateRange.UseVisualStyleBackColor = false;
            // 
            // ManageCustomerOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1375, 783);
            Controls.Add(btnSearchByDateRange);
            Controls.Add(btnRefresh);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSearchCustomer);
            Controls.Add(panel2);
            Controls.Add(orderDetailsGird);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomerOrderForm";
            Text = "ManageCustomerOrderForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsGird).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private DataGridView orderDetailsGird;
        private Panel panel2;
        private Button btnSearchCustomer;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Button btnRefresh;
        private TextBox txtCustomerName;
        private Button btnSearchByDateRange;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column5;
    }
}