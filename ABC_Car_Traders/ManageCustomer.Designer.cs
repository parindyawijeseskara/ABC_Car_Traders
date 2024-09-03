namespace ABC_Car_Traders
{
    partial class ManageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomer));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnAddNewCustomer = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            cmbStatus = new ComboBox();
            panel1 = new Panel();
            txtEmail = new TextBox();
            btnSearchEmail = new Button();
            btnRefresh = new Button();
            dataGridViewCustomers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            label3 = new Label();
            btnSearchStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 115, 144);
            label1.Location = new Point(73, 42);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 362);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.BackColor = Color.FromArgb(35, 115, 144);
            btnAddNewCustomer.FlatAppearance.BorderSize = 0;
            btnAddNewCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewCustomer.ForeColor = SystemColors.ControlLightLight;
            btnAddNewCustomer.ImageAlign = ContentAlignment.MiddleRight;
            btnAddNewCustomer.Location = new Point(1065, 29);
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(260, 76);
            btnAddNewCustomer.TabIndex = 2;
            btnAddNewCustomer.Text = "Add New Customer";
            btnAddNewCustomer.TextAlign = ContentAlignment.MiddleRight;
            btnAddNewCustomer.UseVisualStyleBackColor = false;
            btnAddNewCustomer.Click += btnAddNewCustomer_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(35, 115, 144);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1088, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(689, 192);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 4;
            label2.Text = "Search by Email";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "ACT", "InAct" });
            cmbStatus.Location = new Point(859, 265);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(219, 28);
            cmbStatus.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 115, 144);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(859, 177);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 3);
            panel1.Size = new Size(237, 41);
            panel1.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(0, 0);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 38);
            txtEmail.TabIndex = 11;
            // 
            // btnSearchEmail
            // 
            btnSearchEmail.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchEmail.FlatAppearance.BorderSize = 0;
            btnSearchEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchEmail.ForeColor = SystemColors.ControlLightLight;
            btnSearchEmail.Location = new Point(1151, 176);
            btnSearchEmail.Name = "btnSearchEmail";
            btnSearchEmail.Size = new Size(174, 42);
            btnSearchEmail.TabIndex = 7;
            btnSearchEmail.Text = "Search";
            btnSearchEmail.UseVisualStyleBackColor = false;
            btnSearchEmail.Click += btnSearchEmail_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.FromArgb(35, 115, 144);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(1151, 328);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(174, 42);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 115, 144);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Action });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCustomers.EnableHeadersVisualStyles = false;
            dataGridViewCustomers.Location = new Point(73, 456);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCustomers.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCustomers.Size = new Size(1279, 188);
            dataGridViewCustomers.TabIndex = 9;
            dataGridViewCustomers.CellClick += dataGridView1_CellClick;
            dataGridViewCustomers.CellContentClick += dataGridViewCustomers_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "userId";
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.HeaderText = "Customer Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "firstName";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "email";
            Column3.HeaderText = "Email";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 175;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "address";
            Column4.HeaderText = "Address";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 175;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "contactNo";
            Column5.HeaderText = "Contact No";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 175;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "nic";
            Column6.HeaderText = "Nic";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 135;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "status";
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 135;
            // 
            // Action
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.Teal;
            Action.DefaultCellStyle = dataGridViewCellStyle4;
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Resizable = DataGridViewTriState.True;
            Action.SortMode = DataGridViewColumnSortMode.Automatic;
            Action.Text = "Action";
            Action.UseColumnTextForButtonValue = true;
            Action.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(689, 270);
            label3.Name = "label3";
            label3.Size = new Size(151, 23);
            label3.TabIndex = 10;
            label3.Text = "Search by Status";
            // 
            // btnSearchStatus
            // 
            btnSearchStatus.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchStatus.FlatAppearance.BorderSize = 0;
            btnSearchStatus.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStatus.ForeColor = SystemColors.ControlLightLight;
            btnSearchStatus.Location = new Point(1151, 251);
            btnSearchStatus.Name = "btnSearchStatus";
            btnSearchStatus.Size = new Size(174, 42);
            btnSearchStatus.TabIndex = 11;
            btnSearchStatus.Text = "Search";
            btnSearchStatus.UseVisualStyleBackColor = false;
            btnSearchStatus.Click += btnSearchStatus_Click;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1375, 783);
            Controls.Add(btnSearchStatus);
            Controls.Add(label3);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearchEmail);
            Controls.Add(panel1);
            Controls.Add(cmbStatus);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(btnAddNewCustomer);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomer";
            Text = "ManageCustomer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnAddNewCustomer;
        private PictureBox pictureBox2;
        private Label label2;
        private ComboBox cmbStatus;
        private Panel panel1;
        private Button btnSearchEmail;
        private Button btnRefresh;
        private DataGridView dataGridViewCustomers;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Action;
        private Label label3;
        private TextBox txtEmail;
        private Button btnSearchStatus;
    }
}