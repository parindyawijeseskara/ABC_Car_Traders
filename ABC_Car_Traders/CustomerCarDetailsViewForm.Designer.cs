﻿namespace ABC_Car_Traders
{
    partial class CustomerCarDetailsViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCarDetailsViewForm));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtModel = new TextBox();
            label3 = new Label();
            txtCarBrand = new TextBox();
            label4 = new Label();
            txtYear = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            txtDescription = new TextBox();
            label7 = new Label();
            txtTransmission = new TextBox();
            label8 = new Label();
            label9 = new Label();
            pictureBoxImage = new PictureBox();
            label1 = new Label();
            txtCarName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(56, 137);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 8;
            label2.Text = "Car Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(320, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtModel
            // 
            txtModel.BackColor = SystemColors.Window;
            txtModel.Location = new Point(183, 213);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.Size = new Size(200, 27);
            txtModel.TabIndex = 11;
            txtModel.TextChanged += txtModel_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(56, 298);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 12;
            label3.Text = "Car Brand :";
            // 
            // txtCarBrand
            // 
            txtCarBrand.Location = new Point(183, 296);
            txtCarBrand.Name = "txtCarBrand";
            txtCarBrand.ReadOnly = true;
            txtCarBrand.Size = new Size(200, 27);
            txtCarBrand.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(56, 373);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 14;
            label4.Text = "Year :";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(183, 368);
            txtYear.Name = "txtYear";
            txtYear.ReadOnly = true;
            txtYear.Size = new Size(200, 27);
            txtYear.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 449);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 16;
            label5.Text = "Price : ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(183, 444);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(500, 296);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 18;
            label6.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(624, 282);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(345, 80);
            txtDescription.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(500, 402);
            label7.Name = "label7";
            label7.Size = new Size(131, 23);
            label7.TabIndex = 20;
            label7.Text = "Transmission :";
            // 
            // txtTransmission
            // 
            txtTransmission.Location = new Point(637, 398);
            txtTransmission.Name = "txtTransmission";
            txtTransmission.ReadOnly = true;
            txtTransmission.Size = new Size(200, 27);
            txtTransmission.TabIndex = 21;
            txtTransmission.TextChanged += txtTransmission_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(56, 529);
            label8.Name = "label8";
            label8.Size = new Size(74, 23);
            label8.TabIndex = 22;
            label8.Text = "Image :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(35, 115, 144);
            label9.Location = new Point(53, 55);
            label9.Name = "label9";
            label9.Size = new Size(148, 32);
            label9.TabIndex = 23;
            label9.Text = "Car Details";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(56, 564);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(502, 246);
            pictureBoxImage.TabIndex = 24;
            pictureBoxImage.TabStop = false;
            pictureBoxImage.Click += pictureBoxImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(56, 218);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 25;
            label1.Text = "Car Model :";
            // 
            // txtCarName
            // 
            txtCarName.BackColor = SystemColors.Window;
            txtCarName.Location = new Point(183, 132);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(200, 27);
            txtCarName.TabIndex = 26;
            txtCarName.TextChanged += txtCarName_TextChanged;
            // 
            // CustomerCarDetailsViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1018, 856);
            Controls.Add(txtCarName);
            Controls.Add(label1);
            Controls.Add(pictureBoxImage);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTransmission);
            Controls.Add(label7);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(txtYear);
            Controls.Add(label4);
            Controls.Add(txtCarBrand);
            Controls.Add(label3);
            Controls.Add(txtModel);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "CustomerCarDetailsViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerCarDetailsViewForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtCarBrand;
        private Label label4;
        private TextBox txtYear;
        private Label label5;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtDescription;
        private Label label7;
        private TextBox txtTransmission;
        private Label label8;
        private Label label9;
        private PictureBox pictureBoxImage;
        private Label label1;
        private TextBox txtCarName;
    }
}