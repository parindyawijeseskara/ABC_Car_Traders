﻿namespace ABC_Car_Traders
{
    partial class dasboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dasboard));
            label11 = new Label();
            pictureBox10 = new PictureBox();
            panel1 = new Panel();
            adminDashboard_panel3 = new Panel();
            panel4 = new Panel();
            label14 = new Label();
            pictureBox13 = new PictureBox();
            labelTotalCarOrders = new Label();
            panel3 = new Panel();
            labelTotalCarParts = new Label();
            label13 = new Label();
            pictureBox12 = new PictureBox();
            panel2 = new Panel();
            labelTotalCars = new Label();
            label12 = new Label();
            pictureBox11 = new PictureBox();
            panel6 = new Panel();
            labeltotalCustomers = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel1.SuspendLayout();
            adminDashboard_panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(125, 37);
            label11.Name = "label11";
            label11.Size = new Size(188, 29);
            label11.TabIndex = 1;
            label11.Text = "Total Customers";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(29, 23);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(74, 51);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 115, 144);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox10);
            panel1.Location = new Point(78, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 101);
            panel1.TabIndex = 1;
            // 
            // adminDashboard_panel3
            // 
            adminDashboard_panel3.BackColor = Color.White;
            adminDashboard_panel3.Controls.Add(panel4);
            adminDashboard_panel3.Controls.Add(panel3);
            adminDashboard_panel3.Controls.Add(panel2);
            adminDashboard_panel3.Controls.Add(panel6);
            adminDashboard_panel3.Location = new Point(8, 8);
            adminDashboard_panel3.Name = "adminDashboard_panel3";
            adminDashboard_panel3.Size = new Size(1375, 783);
            adminDashboard_panel3.TabIndex = 3;
            adminDashboard_panel3.Paint += adminDashboard_panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 115, 144);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(pictureBox13);
            panel4.Controls.Add(labelTotalCarOrders);
            panel4.Location = new Point(727, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(538, 129);
            panel4.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(175, 37);
            label14.Name = "label14";
            label14.Size = new Size(149, 29);
            label14.TabIndex = 1;
            label14.Text = "Total Orders";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(49, 18);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(87, 62);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 0;
            pictureBox13.TabStop = false;
            // 
            // labelTotalCarOrders
            // 
            labelTotalCarOrders.AutoSize = true;
            labelTotalCarOrders.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalCarOrders.ForeColor = SystemColors.Control;
            labelTotalCarOrders.Location = new Point(387, 39);
            labelTotalCarOrders.Name = "labelTotalCarOrders";
            labelTotalCarOrders.Size = new Size(90, 35);
            labelTotalCarOrders.TabIndex = 34;
            labelTotalCarOrders.Text = "label7";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 115, 144);
            panel3.Controls.Add(labelTotalCarParts);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox12);
            panel3.Location = new Point(59, 231);
            panel3.Name = "panel3";
            panel3.Size = new Size(538, 129);
            panel3.TabIndex = 2;
            // 
            // labelTotalCarParts
            // 
            labelTotalCarParts.AutoSize = true;
            labelTotalCarParts.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalCarParts.ForeColor = SystemColors.Control;
            labelTotalCarParts.Location = new Point(378, 42);
            labelTotalCarParts.Name = "labelTotalCarParts";
            labelTotalCarParts.Size = new Size(90, 35);
            labelTotalCarParts.TabIndex = 33;
            labelTotalCarParts.Text = "label7";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(137, 35);
            label13.Name = "label13";
            label13.Size = new Size(176, 29);
            label13.TabIndex = 1;
            label13.Text = "Total Car Parts";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(29, 15);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(87, 62);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 0;
            pictureBox12.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 115, 144);
            panel2.Controls.Add(labelTotalCars);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pictureBox11);
            panel2.Location = new Point(727, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 129);
            panel2.TabIndex = 2;
            // 
            // labelTotalCars
            // 
            labelTotalCars.AutoSize = true;
            labelTotalCars.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalCars.ForeColor = SystemColors.Control;
            labelTotalCars.Location = new Point(312, 35);
            labelTotalCars.Name = "labelTotalCars";
            labelTotalCars.Size = new Size(199, 35);
            labelTotalCars.TabIndex = 32;
            labelTotalCars.Text = "labelTotalCars";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(137, 35);
            label12.Name = "label12";
            label12.Size = new Size(123, 29);
            label12.TabIndex = 1;
            label12.Text = "Total Cars";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(29, 15);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(87, 62);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 0;
            pictureBox11.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(35, 115, 144);
            panel6.Controls.Add(labeltotalCustomers);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(59, 42);
            panel6.Name = "panel6";
            panel6.Size = new Size(538, 129);
            panel6.TabIndex = 0;
            // 
            // labeltotalCustomers
            // 
            labeltotalCustomers.AutoSize = true;
            labeltotalCustomers.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltotalCustomers.ForeColor = SystemColors.Control;
            labeltotalCustomers.Location = new Point(378, 42);
            labeltotalCustomers.Name = "labeltotalCustomers";
            labeltotalCustomers.Size = new Size(90, 35);
            labeltotalCustomers.TabIndex = 34;
            labeltotalCustomers.Text = "label7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(162, 42);
            label1.Name = "label1";
            label1.Size = new Size(188, 29);
            label1.TabIndex = 1;
            label1.Text = "Total Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dasboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 783);
            Controls.Add(adminDashboard_panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dasboard";
            Text = "dasboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            adminDashboard_panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label11;
        private PictureBox pictureBox10;
        private Panel panel1;
        private Panel adminDashboard_panel3;
        private Panel panel4;
        private Label label14;
        private PictureBox pictureBox13;
        private Panel panel3;
        private Label label13;
        private PictureBox pictureBox12;
        private Panel panel2;
        private Label label12;
        private PictureBox pictureBox11;
        private Panel panel6;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelTotalCarOrders;
        private Label labelTotalCars;
        private Label labelTotalCarParts;
        private Label labeltotalCustomers;
    }
}