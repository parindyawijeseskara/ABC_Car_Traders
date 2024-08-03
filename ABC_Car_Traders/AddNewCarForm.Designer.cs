namespace ABC_Car_Traders
{
    partial class AddNewCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCarForm));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            txtModel = new TextBox();
            panel2 = new Panel();
            txtBrand = new TextBox();
            panel3 = new Panel();
            txtYear = new TextBox();
            panel4 = new Panel();
            txtPrice = new TextBox();
            panel5 = new Panel();
            txtDescription = new TextBox();
            panel6 = new Panel();
            textBox6 = new TextBox();
            cmbTransmission = new ComboBox();
            btnSaveCar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 115, 144);
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 2;
            label1.Text = "Add New Car";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 3;
            label2.Text = "Model";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(285, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 211);
            label3.Name = "label3";
            label3.Size = new Size(58, 22);
            label3.TabIndex = 5;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 293);
            label4.Name = "label4";
            label4.Size = new Size(47, 22);
            label4.TabIndex = 6;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 380);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 464);
            label6.Name = "label6";
            label6.Size = new Size(103, 22);
            label6.TabIndex = 8;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 550);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 9;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(36, 636);
            label8.Name = "label8";
            label8.Size = new Size(115, 22);
            label8.TabIndex = 10;
            label8.Text = "Transmission";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(36, 719);
            label9.Name = "label9";
            label9.Size = new Size(120, 22);
            label9.TabIndex = 11;
            label9.Text = "Upload Image";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 115, 144);
            panel1.Controls.Add(txtModel);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(36, 150);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 3);
            panel1.Size = new Size(233, 45);
            panel1.TabIndex = 12;
            // 
            // txtModel
            // 
            txtModel.Dock = DockStyle.Fill;
            txtModel.Location = new Point(0, 0);
            txtModel.Multiline = true;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(233, 42);
            txtModel.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 115, 144);
            panel2.Controls.Add(txtBrand);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(36, 236);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 3);
            panel2.Size = new Size(233, 45);
            panel2.TabIndex = 13;
            // 
            // txtBrand
            // 
            txtBrand.Dock = DockStyle.Fill;
            txtBrand.Location = new Point(0, 0);
            txtBrand.Multiline = true;
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(233, 42);
            txtBrand.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 115, 144);
            panel3.Controls.Add(txtYear);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(36, 318);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 3);
            panel3.Size = new Size(233, 45);
            panel3.TabIndex = 14;
            // 
            // txtYear
            // 
            txtYear.Dock = DockStyle.Fill;
            txtYear.Location = new Point(0, 0);
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(233, 42);
            txtYear.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 115, 144);
            panel4.Controls.Add(txtPrice);
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(36, 405);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 3);
            panel4.Size = new Size(233, 45);
            panel4.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(0, 0);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(233, 42);
            txtPrice.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 115, 144);
            panel5.Controls.Add(txtDescription);
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(36, 489);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 0, 3);
            panel5.Size = new Size(233, 45);
            panel5.TabIndex = 16;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Location = new Point(0, 0);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(233, 42);
            txtDescription.TabIndex = 23;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(35, 115, 144);
            panel6.Controls.Add(textBox6);
            panel6.ForeColor = Color.Black;
            panel6.Location = new Point(36, 575);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 0, 0, 3);
            panel6.Size = new Size(233, 45);
            panel6.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(0, 0);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(233, 42);
            textBox6.TabIndex = 24;
            // 
            // cmbTransmission
            // 
            cmbTransmission.FormattingEnabled = true;
            cmbTransmission.Location = new Point(36, 671);
            cmbTransmission.Name = "cmbTransmission";
            cmbTransmission.Size = new Size(233, 28);
            cmbTransmission.TabIndex = 18;
            // 
            // btnSaveCar
            // 
            btnSaveCar.BackColor = Color.FromArgb(35, 115, 144);
            btnSaveCar.FlatAppearance.BorderSize = 0;
            btnSaveCar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSaveCar.ForeColor = SystemColors.ControlLightLight;
            btnSaveCar.Location = new Point(425, 785);
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.Size = new Size(196, 56);
            btnSaveCar.TabIndex = 19;
            btnSaveCar.Text = "Save";
            btnSaveCar.UseVisualStyleBackColor = false;
            // 
            // AddNewCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(689, 869);
            Controls.Add(btnSaveCar);
            Controls.Add(cmbTransmission);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewCarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewCarForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private ComboBox cmbTransmission;
        private TextBox txtModel;
        private TextBox txtBrand;
        private TextBox txtYear;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox textBox6;
        private Button btnSaveCar;
    }
}