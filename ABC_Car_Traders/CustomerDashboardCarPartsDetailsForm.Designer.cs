namespace ABC_Car_Traders
{
    partial class CustomerDashboardCarPartsDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboardCarPartsDetailsForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            txtFromPrice = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            txtToPrice = new TextBox();
            SearchByPriceRange = new Button();
            txtSearchModel = new Button();
            btnSearchByCartPartName = new Button();
            btnReset = new Button();
            dataGridViewCarParts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewButtonColumn();
            cmbBrand = new ComboBox();
            label7 = new Label();
            cmbModel = new ComboBox();
            txtCarPartName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarParts).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 288);
            label2.Name = "label2";
            label2.Size = new Size(226, 23);
            label2.TabIndex = 29;
            label2.Text = "Search by Car Part Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 115, 144);
            label1.Location = new Point(76, 61);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 28;
            label1.Text = "Car Part Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(643, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(684, 366);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 160);
            label3.Name = "label3";
            label3.Size = new Size(149, 23);
            label3.TabIndex = 32;
            label3.Text = "Search by Brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 364);
            label5.Name = "label5";
            label5.Size = new Size(201, 23);
            label5.TabIndex = 34;
            label5.Text = "Search by Price Range";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 115, 144);
            panel4.Controls.Add(txtFromPrice);
            panel4.Location = new Point(283, 348);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 3);
            panel4.Size = new Size(190, 39);
            panel4.TabIndex = 38;
            // 
            // txtFromPrice
            // 
            txtFromPrice.Dock = DockStyle.Fill;
            txtFromPrice.Location = new Point(0, 0);
            txtFromPrice.Multiline = true;
            txtFromPrice.Name = "txtFromPrice";
            txtFromPrice.Size = new Size(190, 36);
            txtFromPrice.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(489, 364);
            label6.Name = "label6";
            label6.Size = new Size(31, 23);
            label6.TabIndex = 39;
            label6.Text = "To";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 115, 144);
            panel5.Controls.Add(txtToPrice);
            panel5.Location = new Point(526, 348);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 0, 3);
            panel5.Size = new Size(190, 39);
            panel5.TabIndex = 39;
            // 
            // txtToPrice
            // 
            txtToPrice.Dock = DockStyle.Fill;
            txtToPrice.Location = new Point(0, 0);
            txtToPrice.Multiline = true;
            txtToPrice.Name = "txtToPrice";
            txtToPrice.Size = new Size(190, 36);
            txtToPrice.TabIndex = 3;
            // 
            // SearchByPriceRange
            // 
            SearchByPriceRange.BackColor = Color.FromArgb(35, 115, 144);
            SearchByPriceRange.FlatAppearance.BorderSize = 0;
            SearchByPriceRange.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            SearchByPriceRange.ForeColor = SystemColors.ControlLightLight;
            SearchByPriceRange.Location = new Point(737, 345);
            SearchByPriceRange.Name = "SearchByPriceRange";
            SearchByPriceRange.Size = new Size(184, 42);
            SearchByPriceRange.TabIndex = 40;
            SearchByPriceRange.Text = "Search";
            SearchByPriceRange.UseVisualStyleBackColor = false;
            SearchByPriceRange.Click += SearchByPriceRange_Click;
            // 
            // txtSearchModel
            // 
            txtSearchModel.BackColor = Color.FromArgb(35, 115, 144);
            txtSearchModel.FlatAppearance.BorderSize = 0;
            txtSearchModel.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            txtSearchModel.ForeColor = SystemColors.ControlLightLight;
            txtSearchModel.Location = new Point(503, 206);
            txtSearchModel.Name = "txtSearchModel";
            txtSearchModel.Size = new Size(184, 42);
            txtSearchModel.TabIndex = 42;
            txtSearchModel.Text = "Search";
            txtSearchModel.UseVisualStyleBackColor = false;
            txtSearchModel.Click += txtSearchModel_Click;
            // 
            // btnSearchByCartPartName
            // 
            btnSearchByCartPartName.BackColor = Color.FromArgb(35, 115, 144);
            btnSearchByCartPartName.FlatAppearance.BorderSize = 0;
            btnSearchByCartPartName.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnSearchByCartPartName.ForeColor = SystemColors.ControlLightLight;
            btnSearchByCartPartName.Location = new Point(503, 269);
            btnSearchByCartPartName.Name = "btnSearchByCartPartName";
            btnSearchByCartPartName.Size = new Size(184, 42);
            btnSearchByCartPartName.TabIndex = 43;
            btnSearchByCartPartName.Text = "Search";
            btnSearchByCartPartName.UseVisualStyleBackColor = false;
            btnSearchByCartPartName.Click += btnSearchByCartPartName_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(35, 115, 144);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.Location = new Point(942, 345);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(184, 42);
            btnReset.TabIndex = 44;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dataGridViewCarParts
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 115, 144);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCarParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCarParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarParts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column13, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridViewCarParts.EnableHeadersVisualStyles = false;
            dataGridViewCarParts.Location = new Point(76, 464);
            dataGridViewCarParts.Name = "dataGridViewCarParts";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCarParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCarParts.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCarParts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCarParts.Size = new Size(1188, 188);
            dataGridViewCarParts.TabIndex = 45;
            dataGridViewCarParts.CellClick += dataGridViewCarParts_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "carPartId";
            Column1.HeaderText = "Car Part Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "carPartName";
            Column2.HeaderText = "Car Part Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "image";
            Column3.HeaderText = "Image";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "modelName";
            Column4.HeaderText = "Model";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column13
            // 
            Column13.DataPropertyName = "brandName";
            Column13.HeaderText = "Brand Name";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 145;
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
            Column6.DataPropertyName = "quantity";
            Column6.HeaderText = "Quantity";
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
            Column8.DataPropertyName = "manufacturer";
            Column8.HeaderText = "Manufacturer";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "warrantyPeriod";
            Column9.HeaderText = "Warranty Period";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 145;
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
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(270, 155);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(203, 28);
            cmbBrand.TabIndex = 46;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(76, 225);
            label7.Name = "label7";
            label7.Size = new Size(151, 23);
            label7.TabIndex = 48;
            label7.Text = "Search by Model";
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(270, 220);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(203, 28);
            cmbModel.TabIndex = 49;
            // 
            // txtCarPartName
            // 
            txtCarPartName.Location = new Point(313, 284);
            txtCarPartName.Name = "txtCarPartName";
            txtCarPartName.Size = new Size(160, 27);
            txtCarPartName.TabIndex = 50;
            // 
            // CustomerDashboardCarPartsDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1339, 689);
            Controls.Add(txtCarPartName);
            Controls.Add(cmbModel);
            Controls.Add(label7);
            Controls.Add(cmbBrand);
            Controls.Add(dataGridViewCarParts);
            Controls.Add(btnReset);
            Controls.Add(btnSearchByCartPartName);
            Controls.Add(txtSearchModel);
            Controls.Add(SearchByPriceRange);
            Controls.Add(panel5);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashboardCarPartsDetailsForm";
            Text = "CustomerDashboardCarPartsDetailsForm";
            Load += CustomerDashboardCarPartsDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
        private Button SearchByPriceRange;
        private Button txtSearchModel;
        private Button btnSearchByCartPartName;
        private Button btnReset;
        private TextBox txtFromPrice;
        private TextBox txtToPrice;
        private DataGridView dataGridViewCarParts;
        private ComboBox cmbBrand;
        private Label label7;
        private ComboBox cmbModel;
        private TextBox txtCarPartName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewButtonColumn Column11;
    }
}