namespace ABC_Car_Traders
{
    partial class ManageCarsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCarsForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnAddNewCar = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbBrand = new ComboBox();
            btnRefresh = new Button();
            btnSearchModel = new Button();
            searchRegNo = new Button();
            panel1 = new Panel();
            txtRegNo = new TextBox();
            label5 = new Label();
            cmbStatus = new ComboBox();
            btnSearchStatus = new Button();
            cmbModel = new ComboBox();
            dataGridViewCars = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 115, 144);
            label1.Location = new Point(79, 45);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Car Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(612, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnAddNewCar
            // 
            btnAddNewCar.BackColor = Color.FromArgb(35, 115, 144);
            btnAddNewCar.FlatAppearance.BorderSize = 0;
            btnAddNewCar.FlatStyle = FlatStyle.Flat;
            btnAddNewCar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewCar.ForeColor = SystemColors.ControlLightLight;
            btnAddNewCar.ImageAlign = ContentAlignment.MiddleRight;
            btnAddNewCar.Location = new Point(1055, 25);
            btnAddNewCar.Name = "btnAddNewCar";
            btnAddNewCar.Size = new Size(290, 76);
            btnAddNewCar.TabIndex = 3;
            btnAddNewCar.Text = "Add New Car";
            btnAddNewCar.UseVisualStyleBackColor = false;
            btnAddNewCar.Click += btnAddNewCar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1074, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(559, 253);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 5;
            label2.Text = "Search Car by Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(561, 194);
            label3.Name = "label3";
            label3.Size = new Size(186, 23);
            label3.TabIndex = 6;
            label3.Text = "Search Car by Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(561, 317);
            label4.Name = "label4";
            label4.Size = new Size(198, 23);
            label4.TabIndex = 7;
            label4.Text = "Search Car by Reg.No";
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(823, 189);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(215, 28);
            cmbBrand.TabIndex = 9;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(35, 115, 144);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(1090, 411);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(184, 42);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchModel
            // 
            btnSearchModel.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchModel.FlatAppearance.BorderSize = 0;
            btnSearchModel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchModel.ForeColor = SystemColors.ControlLightLight;
            btnSearchModel.Location = new Point(1090, 239);
            btnSearchModel.Name = "btnSearchModel";
            btnSearchModel.Size = new Size(184, 42);
            btnSearchModel.TabIndex = 12;
            btnSearchModel.Text = "Search";
            btnSearchModel.UseVisualStyleBackColor = false;
            btnSearchModel.Click += btnSearchModel_Click;
            // 
            // searchRegNo
            // 
            searchRegNo.BackColor = Color.FromArgb(35, 115, 144);
            searchRegNo.FlatAppearance.BorderSize = 0;
            searchRegNo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchRegNo.ForeColor = SystemColors.ControlLightLight;
            searchRegNo.Location = new Point(1090, 298);
            searchRegNo.Name = "searchRegNo";
            searchRegNo.Size = new Size(184, 42);
            searchRegNo.TabIndex = 13;
            searchRegNo.Text = "Search";
            searchRegNo.UseVisualStyleBackColor = false;
            searchRegNo.Click += searchRegNo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 115, 144);
            panel1.Controls.Add(txtRegNo);
            panel1.Location = new Point(823, 299);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 3);
            panel1.Size = new Size(215, 41);
            panel1.TabIndex = 15;
            // 
            // txtRegNo
            // 
            txtRegNo.Dock = DockStyle.Fill;
            txtRegNo.Location = new Point(0, 0);
            txtRegNo.Multiline = true;
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(215, 38);
            txtRegNo.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(561, 377);
            label5.Name = "label5";
            label5.Size = new Size(188, 23);
            label5.TabIndex = 16;
            label5.Text = "Search Car by Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(823, 372);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(215, 28);
            cmbStatus.TabIndex = 17;
            // 
            // btnSearchStatus
            // 
            btnSearchStatus.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchStatus.FlatAppearance.BorderSize = 0;
            btnSearchStatus.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStatus.ForeColor = SystemColors.ControlLightLight;
            btnSearchStatus.Location = new Point(1090, 358);
            btnSearchStatus.Name = "btnSearchStatus";
            btnSearchStatus.Size = new Size(184, 42);
            btnSearchStatus.TabIndex = 18;
            btnSearchStatus.Text = "Search";
            btnSearchStatus.UseVisualStyleBackColor = false;
            btnSearchStatus.Click += btnSearchStatus_Click;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(823, 248);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(215, 28);
            cmbModel.TabIndex = 19;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridViewCars.Location = new Point(60, 506);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.RowHeadersWidth = 51;
            dataGridViewCars.Size = new Size(1228, 188);
            dataGridViewCars.TabIndex = 20;
            dataGridViewCars.CellClick += dataGridViewCars_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "carId";
            Column1.HeaderText = "Car Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "modelName";
            Column2.HeaderText = "Model";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "regNo";
            Column3.HeaderText = "RegNo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "year";
            Column4.HeaderText = "Year";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "price";
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "description";
            Column6.HeaderText = "Description";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "quantity";
            Column7.HeaderText = "Quantity";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "transmission";
            Column8.HeaderText = "Transmission";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "status";
            Column9.HeaderText = "Status";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Action";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // ManageCarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1357, 736);
            Controls.Add(dataGridViewCars);
            Controls.Add(cmbModel);
            Controls.Add(btnSearchStatus);
            Controls.Add(cmbStatus);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(searchRegNo);
            Controls.Add(btnSearchModel);
            Controls.Add(btnRefresh);
            Controls.Add(cmbBrand);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(btnAddNewCar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCarsForm";
            Text = "ManageCarsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnAddNewCar;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbBrand;
        private Button btnRefresh;
        private Button btnSearchModel;
        private Button searchRegNo;
        private Panel panel1;
        private TextBox txtRegNo;
        private Label label5;
        private ComboBox cmbStatus;
        private Button btnSearchStatus;
        private ComboBox cmbModel;
        private DataGridView dataGridViewCars;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewButtonColumn Column10;
    }
}