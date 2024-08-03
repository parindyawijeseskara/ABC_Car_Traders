namespace ABC_Car_Traders
{
    partial class ManageUsersActionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersActionForm));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbUpdateRole = new ComboBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            panel1 = new Panel();
            txtCustomerName = new TextBox();
            panel2 = new Panel();
            txtEmail = new TextBox();
            panel3 = new Panel();
            txtRole = new TextBox();
            panel4 = new Panel();
            txtRegistrationDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 62);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 11;
            label2.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 169);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 12;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 265);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 13;
            label3.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 370);
            label4.Name = "label4";
            label4.Size = new Size(148, 22);
            label4.TabIndex = 14;
            label4.Text = "Registration Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 470);
            label5.Name = "label5";
            label5.Size = new Size(109, 22);
            label5.TabIndex = 15;
            label5.Text = "Update Role";
            // 
            // cmbUpdateRole
            // 
            cmbUpdateRole.FormattingEnabled = true;
            cmbUpdateRole.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbUpdateRole.Location = new Point(38, 495);
            cmbUpdateRole.Name = "cmbUpdateRole";
            cmbUpdateRole.Size = new Size(182, 28);
            cmbUpdateRole.TabIndex = 20;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(35, 115, 144);
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(424, 632);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 55);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(35, 115, 144);
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(229, 632);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 55);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 115, 144);
            panel1.Controls.Add(txtCustomerName);
            panel1.Location = new Point(38, 96);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 3);
            panel1.Size = new Size(250, 51);
            panel1.TabIndex = 29;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Dock = DockStyle.Fill;
            txtCustomerName.Location = new Point(0, 0);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(250, 48);
            txtCustomerName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 115, 144);
            panel2.Controls.Add(txtEmail);
            panel2.Location = new Point(38, 194);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 3);
            panel2.Size = new Size(250, 51);
            panel2.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(0, 0);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 48);
            txtEmail.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 115, 144);
            panel3.Controls.Add(txtRole);
            panel3.Location = new Point(38, 290);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 3);
            panel3.Size = new Size(250, 51);
            panel3.TabIndex = 32;
            // 
            // txtRole
            // 
            txtRole.Dock = DockStyle.Fill;
            txtRole.Location = new Point(0, 0);
            txtRole.Multiline = true;
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(250, 48);
            txtRole.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 115, 144);
            panel4.Controls.Add(txtRegistrationDate);
            panel4.Location = new Point(38, 395);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 3);
            panel4.Size = new Size(250, 51);
            panel4.TabIndex = 33;
            // 
            // txtRegistrationDate
            // 
            txtRegistrationDate.Dock = DockStyle.Fill;
            txtRegistrationDate.Location = new Point(0, 0);
            txtRegistrationDate.Multiline = true;
            txtRegistrationDate.Name = "txtRegistrationDate";
            txtRegistrationDate.Size = new Size(250, 48);
            txtRegistrationDate.TabIndex = 3;
            // 
            // ManageUsersActionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(652, 753);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(cmbUpdateRole);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "ManageUsersActionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsersActionForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbUpdateRole;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtCustomerName;
        private TextBox txtEmail;
        private TextBox txtRole;
        private TextBox txtRegistrationDate;
    }
}