namespace ABC_Car_Traders
{
    partial class ManageProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProfile));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFirstName = new TextBox();
            btnUpdateProfileDetails = new Button();
            txtLastName = new TextBox();
            txtNic = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtContactNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 115, 144);
            label1.Location = new Point(82, 70);
            label1.Name = "label1";
            label1.Size = new Size(286, 32);
            label1.TabIndex = 2;
            label1.Text = "Manage Profile Details";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(671, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(674, 441);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 208);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 7;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 285);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 361);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 9;
            label4.Text = "Nic";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 504);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 428);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(82, 600);
            label7.Name = "label7";
            label7.Size = new Size(128, 25);
            label7.TabIndex = 12;
            label7.Text = "Contact No";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(236, 208);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(349, 27);
            txtFirstName.TabIndex = 13;
            // 
            // btnUpdateProfileDetails
            // 
            btnUpdateProfileDetails.BackColor = Color.FromArgb(35, 115, 144);
            btnUpdateProfileDetails.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProfileDetails.ForeColor = SystemColors.Control;
            btnUpdateProfileDetails.Location = new Point(896, 581);
            btnUpdateProfileDetails.Name = "btnUpdateProfileDetails";
            btnUpdateProfileDetails.Size = new Size(282, 69);
            btnUpdateProfileDetails.TabIndex = 14;
            btnUpdateProfileDetails.Text = "Update Details";
            btnUpdateProfileDetails.UseVisualStyleBackColor = false;
            btnUpdateProfileDetails.Click += btnUpdateProfileDetails_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(236, 283);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(349, 27);
            txtLastName.TabIndex = 15;
            // 
            // txtNic
            // 
            txtNic.Location = new Point(236, 359);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(349, 27);
            txtNic.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(236, 426);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(236, 502);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(349, 27);
            txtAddress.TabIndex = 18;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(236, 598);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(349, 27);
            txtContactNo.TabIndex = 19;
            // 
            // ManageProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1357, 736);
            Controls.Add(txtContactNo);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtNic);
            Controls.Add(txtLastName);
            Controls.Add(btnUpdateProfileDetails);
            Controls.Add(txtFirstName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProfile";
            Text = "ManageProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFirstName;
        private Button btnUpdateProfileDetails;
        private TextBox txtLastName;
        private TextBox txtNic;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtContactNo;
    }
}