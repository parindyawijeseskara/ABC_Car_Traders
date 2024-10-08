﻿namespace ABC_Car_Traders
{
    partial class CustomerCarPartsDetailViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCarPartsDetailViewForm));
            pictureBox1 = new PictureBox();
            label9 = new Label();
            txtModel = new TextBox();
            label2 = new Label();
            txtCarPartName = new TextBox();
            label1 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtStatus = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtManufacturer = new TextBox();
            label10 = new Label();
            txtWarrantyPeriod = new TextBox();
            pictureBoxImage = new PictureBox();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(674, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(35, 115, 144);
            label9.Location = new Point(49, 47);
            label9.Name = "label9";
            label9.Size = new Size(208, 32);
            label9.TabIndex = 26;
            label9.Text = "Car Part Details";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(205, 217);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.Size = new Size(200, 27);
            txtModel.TabIndex = 25;
            txtModel.TextChanged += txtModel_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(49, 221);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 24;
            label2.Text = "Car Model :";
            // 
            // txtCarPartName
            // 
            txtCarPartName.Location = new Point(205, 145);
            txtCarPartName.Name = "txtCarPartName";
            txtCarPartName.ReadOnly = true;
            txtCarPartName.Size = new Size(200, 27);
            txtCarPartName.TabIndex = 28;
            txtCarPartName.TextChanged += txtCarPartName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(49, 146);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 27;
            label1.Text = "Car Part Name :";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(205, 302);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(49, 306);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 29;
            label3.Text = "Price :";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(205, 378);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(49, 382);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 31;
            label4.Text = "Quantity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(501, 306);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 33;
            label5.Text = "Description :";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(646, 461);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(200, 27);
            txtStatus.TabIndex = 36;
            txtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(501, 465);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 35;
            label6.Text = "Status :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(49, 534);
            label7.Name = "label7";
            label7.Size = new Size(82, 23);
            label7.TabIndex = 37;
            label7.Text = "Images :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(501, 399);
            label8.Name = "label8";
            label8.Size = new Size(139, 23);
            label8.TabIndex = 38;
            label8.Text = "Manufacturer :";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(646, 395);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.ReadOnly = true;
            txtManufacturer.Size = new Size(200, 27);
            txtManufacturer.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(59, 465);
            label10.Name = "label10";
            label10.Size = new Size(163, 23);
            label10.TabIndex = 40;
            label10.Text = "Warranty Period :";
            // 
            // txtWarrantyPeriod
            // 
            txtWarrantyPeriod.Location = new Point(238, 461);
            txtWarrantyPeriod.Name = "txtWarrantyPeriod";
            txtWarrantyPeriod.ReadOnly = true;
            txtWarrantyPeriod.Size = new Size(200, 27);
            txtWarrantyPeriod.TabIndex = 41;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(49, 559);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(502, 246);
            pictureBoxImage.TabIndex = 42;
            pictureBoxImage.TabStop = false;
            pictureBoxImage.Click += pictureBoxImage_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(646, 276);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(345, 80);
            txtDescription.TabIndex = 43;
            // 
            // CustomerCarPartsDetailViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1018, 856);
            Controls.Add(txtDescription);
            Controls.Add(pictureBoxImage);
            Controls.Add(txtWarrantyPeriod);
            Controls.Add(label10);
            Controls.Add(txtManufacturer);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtStatus);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtCarPartName);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(txtModel);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "CustomerCarPartsDetailViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerCarPartsDetailViewForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label9;
        private TextBox txtModel;
        private Label label2;
        private TextBox txtCarPartName;
        private Label label1;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtQuantity;
        private Label label4;
        private Label label5;
        private TextBox txtStatus;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtManufacturer;
        private Label label10;
        private TextBox txtWarrantyPeriod;
        private PictureBox pictureBoxImage;
        private TextBox txtDescription;
    }
}