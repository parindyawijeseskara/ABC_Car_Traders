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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnSearch = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
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
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            Column6 = new DataGridViewButtonColumn();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsGird).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(35, 115, 144);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(1086, 186);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 42);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(597, 205);
            label2.Name = "label2";
            label2.Size = new Size(172, 23);
            label2.TabIndex = 13;
            label2.Text = "Search by Order Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(597, 269);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 115, 144);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            orderDetailsGird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            orderDetailsGird.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailsGird.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column10, Column8, Column3, Column4, Column9, Column7, Column5, Column6 });
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            Column5.DefaultCellStyle = dataGridViewCellStyle2;
            Column5.HeaderText = "View";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Text = "View";
            Column5.Width = 150;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Teal;
            Column6.DefaultCellStyle = dataGridViewCellStyle3;
            Column6.HeaderText = "Actions";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Text = "Actions";
            Column6.Width = 145;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 115, 144);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(838, 182);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 3);
            panel1.Size = new Size(215, 46);
            panel1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 43);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 115, 144);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(838, 246);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 3);
            panel2.Size = new Size(215, 46);
            panel2.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(0, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 43);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 115, 144);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1086, 250);
            button1.Name = "button1";
            button1.Size = new Size(174, 42);
            button1.TabIndex = 20;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // button3
            // 
            button3.BackColor = Color.FromArgb(35, 115, 144);
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(1086, 376);
            button3.Name = "button3";
            button3.Size = new Size(174, 42);
            button3.TabIndex = 25;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 115, 144);
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(894, 376);
            button2.Name = "button2";
            button2.Size = new Size(174, 42);
            button2.TabIndex = 26;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // ManageCustomerOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1375, 783);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(orderDetailsGird);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomerOrderForm";
            Text = "ManageCustomerOrderForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsGird).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView orderDetailsGird;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column5;
        private DataGridViewButtonColumn Column6;
    }
}