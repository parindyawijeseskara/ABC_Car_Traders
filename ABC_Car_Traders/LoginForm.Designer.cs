
namespace ABC_Car_Traders
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel = new Panel();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            link_Register = new LinkLabel();
            label5 = new Label();
            btnLogin = new Button();
            panel4 = new Panel();
            txtPassword = new TextBox();
            panel3 = new Panel();
            txtUserName = new TextBox();
            cmbUserRole = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            loginPanel = new Panel();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMain.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(35, 115, 144);
            panel.Controls.Add(pictureBox1);
            panel.Location = new Point(28, 74);
            panel.Name = "panel";
            panel.Size = new Size(370, 463);
            panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 84);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panel);
            panelMain.Controls.Add(link_Register);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(panel4);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(cmbUserRole);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(875, 589);
            panelMain.TabIndex = 1;
            // 
            // link_Register
            // 
            link_Register.AutoSize = true;
            link_Register.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_Register.Location = new Point(646, 482);
            link_Register.Name = "link_Register";
            link_Register.Size = new Size(76, 22);
            link_Register.TabIndex = 10;
            link_Register.TabStop = true;
            link_Register.Text = "Register";
            link_Register.LinkClicked += link_Register_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(453, 482);
            label5.Name = "label5";
            label5.Size = new Size(187, 22);
            label5.TabIndex = 9;
            label5.Text = "Don't Have Account ? ";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(35, 115, 144);
            btnLogin.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(546, 356);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 48);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 115, 144);
            panel4.Controls.Add(txtPassword);
            panel4.Location = new Point(619, 189);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 3);
            panel4.Size = new Size(214, 39);
            panel4.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(0, 0);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(214, 36);
            txtPassword.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 115, 144);
            panel3.Controls.Add(txtUserName);
            panel3.Location = new Point(619, 120);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 3);
            panel3.Size = new Size(214, 39);
            panel3.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Location = new Point(0, 0);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(214, 36);
            txtUserName.TabIndex = 11;
            // 
            // cmbUserRole
            // 
            cmbUserRole.FormattingEnabled = true;
            cmbUserRole.Items.AddRange(new object[] { "Admin", "Customer" });
            cmbUserRole.Location = new Point(619, 262);
            cmbUserRole.Name = "cmbUserRole";
            cmbUserRole.Size = new Size(214, 28);
            cmbUserRole.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(453, 268);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 4;
            label4.Text = "User Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(453, 206);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(453, 137);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 23);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(panelMain);
            loginPanel.Location = new Point(-2, -1);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(875, 590);
            loginPanel.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 585);
            Controls.Add(loginPanel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            loginPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion
        private Panel panel;
        private PictureBox pictureBox1;
        private Panel panelMain;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbUserRole;
        private Panel panel3;
        private Panel panel4;
        private Button btnLogin;
        private Label label5;
        private LinkLabel link_Register;
        private Button button2;
        private Panel loginPanel;
        private TextBox txtPassword;
        private TextBox txtUserName;
    }
}
