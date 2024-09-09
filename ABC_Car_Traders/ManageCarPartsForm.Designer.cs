namespace ABC_Car_Traders
{
    partial class ManageCarPartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCarPartsForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            btnAddNewCarPart = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            cmbModel = new ComboBox();
            btnRefresh = new Button();
            btnSearchModel = new Button();
            txtSearchName = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            cmbBrand = new ComboBox();
            txtSearchStatus = new Button();
            txtName = new TextBox();
            label5 = new Label();
            txtStatus = new TextBox();
            dataGridViewCarParts = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarParts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 115, 144);
            label1.Location = new Point(72, 52);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 2;
            label1.Text = "Manage Car Parts";
            // 
            // btnAddNewCarPart
            // 
            btnAddNewCarPart.BackColor = Color.FromArgb(35, 115, 144);
            btnAddNewCarPart.FlatAppearance.BorderSize = 0;
            btnAddNewCarPart.FlatStyle = FlatStyle.Flat;
            btnAddNewCarPart.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewCarPart.ForeColor = SystemColors.ControlLightLight;
            btnAddNewCarPart.ImageAlign = ContentAlignment.MiddleRight;
            btnAddNewCarPart.Location = new Point(1007, 32);
            btnAddNewCarPart.Name = "btnAddNewCarPart";
            btnAddNewCarPart.Size = new Size(290, 76);
            btnAddNewCarPart.TabIndex = 11;
            btnAddNewCarPart.Text = "Add New Car Part";
            btnAddNewCarPart.UseVisualStyleBackColor = false;
            btnAddNewCarPart.Click += btnAddNewCarPart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(602, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(593, 277);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 15;
            label2.Text = "Search By Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(593, 223);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 16;
            label3.Text = "Search By Model";
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(789, 218);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(239, 28);
            cmbModel.TabIndex = 17;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(35, 115, 144);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(1071, 376);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(184, 42);
            btnRefresh.TabIndex = 23;
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
            btnSearchModel.Location = new Point(1071, 204);
            btnSearchModel.Name = "btnSearchModel";
            btnSearchModel.Size = new Size(184, 42);
            btnSearchModel.TabIndex = 22;
            btnSearchModel.Text = "Search";
            btnSearchModel.UseVisualStyleBackColor = false;
            btnSearchModel.Click += btnSearchModel_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.BackColor = Color.FromArgb(35, 115, 144);
            txtSearchName.FlatAppearance.BorderSize = 0;
            txtSearchName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchName.ForeColor = SystemColors.ControlLightLight;
            txtSearchName.Location = new Point(1071, 264);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(184, 42);
            txtSearchName.TabIndex = 24;
            txtSearchName.Text = "Search";
            txtSearchName.UseVisualStyleBackColor = false;
            txtSearchName.Click += txtSearchName_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(35, 115, 144);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1018, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(593, 172);
            label4.Name = "label4";
            label4.Size = new Size(186, 23);
            label4.TabIndex = 26;
            label4.Text = "Search Car by Brand";
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(789, 167);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(239, 28);
            cmbBrand.TabIndex = 27;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            // 
            // txtSearchStatus
            // 
            txtSearchStatus.BackColor = Color.FromArgb(35, 115, 144);
            txtSearchStatus.FlatAppearance.BorderSize = 0;
            txtSearchStatus.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchStatus.ForeColor = SystemColors.ControlLightLight;
            txtSearchStatus.Location = new Point(1071, 319);
            txtSearchStatus.Name = "txtSearchStatus";
            txtSearchStatus.Size = new Size(184, 42);
            txtSearchStatus.TabIndex = 28;
            txtSearchStatus.Text = "Search";
            txtSearchStatus.UseVisualStyleBackColor = false;
            txtSearchStatus.Click += txtSearchStatus_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(789, 277);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 27);
            txtName.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(593, 338);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 30;
            label5.Text = "Search By Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(784, 334);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(224, 27);
            txtStatus.TabIndex = 31;
            // 
            // dataGridViewCarParts
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 115, 144);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCarParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCarParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarParts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridViewCarParts.EnableHeadersVisualStyles = false;
            dataGridViewCarParts.Location = new Point(53, 493);
            dataGridViewCarParts.Name = "dataGridViewCarParts";
            dataGridViewCarParts.RowHeadersWidth = 51;
            dataGridViewCarParts.Size = new Size(1225, 205);
            dataGridViewCarParts.TabIndex = 32;
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
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "brandName";
            Column3.HeaderText = "Brand Name";
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
            // ManageCarPartsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1357, 736);
            Controls.Add(dataGridViewCarParts);
            Controls.Add(txtStatus);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(txtSearchStatus);
            Controls.Add(cmbBrand);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(txtSearchName);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearchModel);
            Controls.Add(cmbModel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddNewCarPart);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCarPartsForm";
            Text = "ManageCarPartsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddNewCarPart;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private ComboBox cmbModel;
        private Button btnRefresh;
        private Button btnSearchModel;
        private Button txtSearchName;
        private PictureBox pictureBox2;
        private Label label4;
        private ComboBox cmbBrand;
        private Button txtSearchStatus;
        private TextBox txtName;
        private Label label5;
        private TextBox txtStatus;
        private DataGridView dataGridViewCarParts;
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
    }
}