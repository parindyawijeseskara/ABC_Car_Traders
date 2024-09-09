namespace ABC_Car_Traders
{
    partial class RegistrationForm
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
            label1 = new Label();
            btnRegister = new Button();
            txtFirstName = new TextBox();
            cmbRole = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            label9 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            txtNic = new TextBox();
            label11 = new Label();
            txtContactNo = new TextBox();
            panel1 = new Panel();
            txtUserName = new TextBox();
            label13 = new Label();
            label12 = new Label();
            registrationPanel = new Panel();
            panel1.SuspendLayout();
            registrationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 21);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(35, 115, 144);
            btnRegister.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(162, 393);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(458, 50);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(150, 84);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 27);
            txtFirstName.TabIndex = 2;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(534, 240);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(175, 28);
            cmbRole.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(50, 91);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.Location = new Point(50, 137);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F);
            label4.Location = new Point(50, 192);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F);
            label5.Location = new Point(384, 141);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F);
            label6.Location = new Point(384, 192);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 8;
            label6.Text = "Confirm Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F);
            label7.Location = new Point(389, 248);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 9;
            label7.Text = "User Role";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 130);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(175, 27);
            txtLastName.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(534, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(175, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(534, 185);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(175, 27);
            txtConfirmPassword.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(237, 457);
            label8.Name = "label8";
            label8.Size = new Size(167, 20);
            label8.TabIndex = 14;
            label8.Text = "Already Have Account ?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(410, 457);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F);
            label9.Location = new Point(50, 236);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 16;
            label9.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 233);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(175, 27);
            txtAddress.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.8F);
            label10.Location = new Point(50, 291);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 18;
            label10.Text = "Contact No";
            // 
            // txtNic
            // 
            txtNic.Location = new Point(150, 333);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(175, 27);
            txtNic.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(294, 336);
            label11.Name = "label11";
            label11.Size = new Size(31, 20);
            label11.TabIndex = 20;
            label11.Text = "Nic";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(150, 284);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(175, 27);
            txtContactNo.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(txtNic);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtContactNo);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(48, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 502);
            panel1.TabIndex = 22;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(534, 88);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(175, 27);
            txtUserName.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10.8F);
            label13.Location = new Point(384, 91);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 23;
            label13.Text = "UserName";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10.8F);
            label12.Location = new Point(50, 340);
            label12.Name = "label12";
            label12.Size = new Size(34, 20);
            label12.TabIndex = 22;
            label12.Text = "Nic";
            // 
            // registrationPanel
            // 
            registrationPanel.Controls.Add(panel1);
            registrationPanel.Location = new Point(0, 1);
            registrationPanel.Name = "registrationPanel";
            registrationPanel.Size = new Size(865, 584);
            registrationPanel.TabIndex = 23;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 115, 144);
            ClientSize = new Size(868, 585);
            Controls.Add(registrationPanel);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            registrationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnRegister;
        private TextBox txtFirstName;
        private ComboBox cmbRole;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label8;
        private LinkLabel linkLabel1;
        private Label label9;
        private TextBox txtAddress;
        private Label label10;
        private TextBox txtNic;
        private Label label11;
        private TextBox txtContactNo;
        private Panel panel1;
        private Label label12;
        private Label label13;
        private TextBox txtUserName;
        private Panel registrationPanel;
    }
}