namespace ABC_Car_Traders
{
    partial class CustomerDashboardCarDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardCarDetailsForm));
            btnSearchModel = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            cmbModel = new ComboBox();
            panel1 = new Panel();
            txtYear = new TextBox();
            panel2 = new Panel();
            txtFromPriceRange = new TextBox();
            btnSearchYear = new Button();
            btnSearchPriceRange = new Button();
            btnReset = new Button();
            dataGridViewCars = new DataGridView();
            label5 = new Label();
            panel3 = new Panel();
            txtToPriceRange = new TextBox();
            label6 = new Label();
            cmbBrand = new ComboBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewButtonColumn();
            Column12 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearchModel
            // 
            btnSearchModel.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchModel.FlatAppearance.BorderSize = 0;
            btnSearchModel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchModel.ForeColor = SystemColors.ControlLightLight;
            btnSearchModel.Location = new Point(414, 167);
            btnSearchModel.Name = "btnSearchModel";
            btnSearchModel.Size = new Size(184, 42);
            btnSearchModel.TabIndex = 27;
            btnSearchModel.Text = "Search";
            btnSearchModel.UseVisualStyleBackColor = false;
            btnSearchModel.Click += btnSearchModel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 181);
            label2.Name = "label2";
            label2.Size = new Size(154, 23);
            label2.TabIndex = 26;
            label2.Text = "Search By Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 115, 144);
            label1.Location = new Point(65, 74);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 25;
            label1.Text = "Car Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(637, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(690, 359);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 244);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 31;
            label3.Text = "Search By Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 315);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 32;
            label4.Text = "Price Range";
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(244, 176);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(151, 28);
            cmbModel.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 115, 144);
            panel1.Controls.Add(txtYear);
            panel1.Location = new Point(235, 228);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 3);
            panel1.Size = new Size(219, 39);
            panel1.TabIndex = 34;
            // 
            // txtYear
            // 
            txtYear.Dock = DockStyle.Fill;
            txtYear.Location = new Point(0, 0);
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(219, 36);
            txtYear.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 115, 144);
            panel2.Controls.Add(txtFromPriceRange);
            panel2.Location = new Point(235, 299);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 3);
            panel2.Size = new Size(219, 39);
            panel2.TabIndex = 35;
            // 
            // txtFromPriceRange
            // 
            txtFromPriceRange.Dock = DockStyle.Fill;
            txtFromPriceRange.Location = new Point(0, 0);
            txtFromPriceRange.Multiline = true;
            txtFromPriceRange.Name = "txtFromPriceRange";
            txtFromPriceRange.Size = new Size(219, 36);
            txtFromPriceRange.TabIndex = 1;
            // 
            // btnSearchYear
            // 
            btnSearchYear.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchYear.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSearchYear.ForeColor = SystemColors.ControlLightLight;
            btnSearchYear.Location = new Point(475, 225);
            btnSearchYear.Name = "btnSearchYear";
            btnSearchYear.Size = new Size(184, 42);
            btnSearchYear.TabIndex = 36;
            btnSearchYear.Text = "Search";
            btnSearchYear.UseVisualStyleBackColor = false;
            btnSearchYear.Click += btnSearchYear_Click;
            // 
            // btnSearchPriceRange
            // 
            btnSearchPriceRange.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchPriceRange.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSearchPriceRange.ForeColor = SystemColors.ControlLightLight;
            btnSearchPriceRange.Location = new Point(752, 296);
            btnSearchPriceRange.Name = "btnSearchPriceRange";
            btnSearchPriceRange.Size = new Size(184, 42);
            btnSearchPriceRange.TabIndex = 37;
            btnSearchPriceRange.Text = "Search";
            btnSearchPriceRange.UseVisualStyleBackColor = false;
            btnSearchPriceRange.Click += btnSearchPriceRange_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(35, 115, 144);
            btnReset.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.Location = new Point(954, 296);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(184, 42);
            btnReset.TabIndex = 38;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            dataGridViewCars.Location = new Point(44, 420);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.RowHeadersWidth = 51;
            dataGridViewCars.Size = new Size(1269, 288);
            dataGridViewCars.TabIndex = 39;
            dataGridViewCars.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(475, 315);
            label5.Name = "label5";
            label5.Size = new Size(31, 23);
            label5.TabIndex = 40;
            label5.Text = "To";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 115, 144);
            panel3.Controls.Add(txtToPriceRange);
            panel3.Location = new Point(512, 299);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 3);
            panel3.Size = new Size(219, 39);
            panel3.TabIndex = 36;
            // 
            // txtToPriceRange
            // 
            txtToPriceRange.Dock = DockStyle.Fill;
            txtToPriceRange.Location = new Point(0, 0);
            txtToPriceRange.Multiline = true;
            txtToPriceRange.Name = "txtToPriceRange";
            txtToPriceRange.Size = new Size(219, 36);
            txtToPriceRange.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 136);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 41;
            label6.Text = "Search By Brand";
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(244, 135);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(151, 28);
            cmbBrand.TabIndex = 42;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
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
            Column2.DataPropertyName = "regNo";
            Column2.HeaderText = "Car RegNo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "modelName";
            Column3.HeaderText = "Model";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "brandName";
            Column4.HeaderText = "Brand";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "year";
            Column5.HeaderText = "Year";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "price";
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "description";
            Column7.HeaderText = "Description";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "quantity";
            Column8.HeaderText = "Stock Quantity";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "transmission";
            Column9.HeaderText = "Transmission";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "status";
            Column10.HeaderText = "Status";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "View Details";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Place Order";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 125;
            // 
            // CustomerDashboardCarDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1357, 736);
            Controls.Add(cmbBrand);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(dataGridViewCars);
            Controls.Add(btnReset);
            Controls.Add(btnSearchPriceRange);
            Controls.Add(btnSearchYear);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cmbModel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnSearchModel);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashboardCarDetailsForm";
            Text = "CustomerDashboardCarDetailsForm";
            Load += CustomerDashboardCarDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearchModel;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private ComboBox cmbModel;
        private Panel panel1;
        private Panel panel2;
        private Button btnSearchYear;
        private Button btnSearchPriceRange;
        private Button btnReset;
        private DataGridView dataGridViewCars;
        private Label label5;
        private Panel panel3;
        private TextBox txtYear;
        private TextBox txtFromPriceRange;
        private TextBox txtToPriceRange;
        private Label label6;
        private ComboBox cmbBrand;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewButtonColumn Column11;
        private DataGridViewButtonColumn Column12;
    }
}