
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
            PanelRegister = new Panel();
            link_Login = new LinkLabel();
            label12 = new Label();
            btnRegister_Click = new Button();
            panel9 = new Panel();
            textBox7 = new TextBox();
            label11 = new Label();
            panel8 = new Panel();
            textBox6 = new TextBox();
            label10 = new Label();
            panel7 = new Panel();
            textBox5 = new TextBox();
            label9 = new Label();
            panel6 = new Panel();
            textBox4 = new TextBox();
            label8 = new Label();
            panel5 = new Panel();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            link_Register = new LinkLabel();
            label5 = new Label();
            button1 = new Button();
            panel4 = new Panel();
            textBox2 = new TextBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMain.SuspendLayout();
            PanelRegister.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(35, 115, 144);
            panel.Controls.Add(pictureBox1);
            panel.Location = new Point(1, 0);
            panel.Name = "panel";
            panel.Size = new Size(370, 517);
            panel.TabIndex = 0;
            panel.Paint += panel_Paint;
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
            panelMain.Controls.Add(PanelRegister);
            panelMain.Controls.Add(link_Register);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(panel4);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(comboBox1);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Location = new Point(368, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(459, 520);
            panelMain.TabIndex = 1;
            // 
            // PanelRegister
            // 
            PanelRegister.Controls.Add(link_Login);
            PanelRegister.Controls.Add(label12);
            PanelRegister.Controls.Add(btnRegister_Click);
            PanelRegister.Controls.Add(panel9);
            PanelRegister.Controls.Add(label11);
            PanelRegister.Controls.Add(panel8);
            PanelRegister.Controls.Add(label10);
            PanelRegister.Controls.Add(panel7);
            PanelRegister.Controls.Add(label9);
            PanelRegister.Controls.Add(panel6);
            PanelRegister.Controls.Add(label8);
            PanelRegister.Controls.Add(panel5);
            PanelRegister.Controls.Add(label7);
            PanelRegister.Controls.Add(label6);
            PanelRegister.Dock = DockStyle.Bottom;
            PanelRegister.Location = new Point(0, 494);
            PanelRegister.Name = "PanelRegister";
            PanelRegister.Size = new Size(459, 26);
            PanelRegister.TabIndex = 11;
            // 
            // link_Login
            // 
            link_Login.AutoSize = true;
            link_Login.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_Login.Location = new Point(270, 479);
            link_Login.Name = "link_Login";
            link_Login.Size = new Size(49, 19);
            link_Login.TabIndex = 9;
            link_Login.TabStop = true;
            link_Login.Text = "Login";
            link_Login.LinkClicked += link_Login_LinkClicked;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(89, 479);
            label12.Name = "label12";
            label12.Size = new Size(175, 19);
            label12.TabIndex = 8;
            label12.Text = "Already Have Account ? ";
            // 
            // btnRegister_Click
            // 
            btnRegister_Click.BackColor = Color.FromArgb(35, 115, 144);
            btnRegister_Click.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister_Click.ForeColor = SystemColors.ControlLightLight;
            btnRegister_Click.Location = new Point(148, 416);
            btnRegister_Click.Name = "btnRegister_Click";
            btnRegister_Click.Size = new Size(188, 38);
            btnRegister_Click.TabIndex = 7;
            btnRegister_Click.Text = "Register";
            btnRegister_Click.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(35, 115, 144);
            panel9.Controls.Add(textBox7);
            panel9.Location = new Point(202, 350);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 0, 0, 3);
            panel9.Size = new Size(213, 37);
            panel9.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Dock = DockStyle.Fill;
            textBox7.Location = new Point(0, 0);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(213, 34);
            textBox7.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(26, 365);
            label11.Name = "label11";
            label11.Size = new Size(158, 22);
            label11.TabIndex = 6;
            label11.Text = "Confirm Password";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(35, 115, 144);
            panel8.Controls.Add(textBox6);
            panel8.Location = new Point(203, 286);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 0, 0, 3);
            panel8.Size = new Size(213, 37);
            panel8.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(0, 0);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(213, 34);
            textBox6.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 301);
            label10.Name = "label10";
            label10.Size = new Size(88, 22);
            label10.TabIndex = 5;
            label10.Text = "Password";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(35, 115, 144);
            panel7.Controls.Add(textBox5);
            panel7.Location = new Point(203, 223);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 0, 0, 3);
            panel7.Size = new Size(213, 37);
            panel7.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(0, 0);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 34);
            textBox5.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(26, 238);
            label9.Name = "label9";
            label9.Size = new Size(145, 22);
            label9.TabIndex = 4;
            label9.Text = "Enter User Name";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(35, 115, 144);
            panel6.Controls.Add(textBox4);
            panel6.Location = new Point(205, 166);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 0, 0, 3);
            panel6.Size = new Size(213, 37);
            panel6.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(0, 0);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 34);
            textBox4.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 181);
            label8.Name = "label8";
            label8.Size = new Size(57, 22);
            label8.TabIndex = 3;
            label8.Text = "Email";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 115, 144);
            panel5.Controls.Add(textBox3);
            panel5.Location = new Point(205, 100);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 0, 3);
            panel5.Size = new Size(213, 37);
            panel5.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(0, 0);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 34);
            textBox3.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 114);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 1;
            label7.Text = "Full Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(178, 30);
            label6.Name = "label6";
            label6.Size = new Size(112, 32);
            label6.TabIndex = 0;
            label6.Text = "Register";
            // 
            // link_Register
            // 
            link_Register.AutoSize = true;
            link_Register.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_Register.Location = new Point(270, 457);
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
            label5.Location = new Point(90, 457);
            label5.Name = "label5";
            label5.Size = new Size(187, 22);
            label5.TabIndex = 9;
            label5.Text = "Don't Have Account ? ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 115, 144);
            button1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(158, 372);
            button1.Name = "button1";
            button1.Size = new Size(167, 48);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 115, 144);
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(202, 194);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 3);
            panel4.Size = new Size(214, 39);
            panel4.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(0, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 36);
            textBox2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 115, 144);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(202, 124);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 3);
            panel3.Size = new Size(214, 39);
            panel3.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 36);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Customer" });
            comboBox1.Location = new Point(202, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 28);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 277);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 4;
            label4.Text = "User Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 211);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 141);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 30);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(826, 517);
            Controls.Add(panelMain);
            Controls.Add(panel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            PanelRegister.ResumeLayout(false);
            PanelRegister.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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

        private void button1_Click_1(object sender, EventArgs e)
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
        private ComboBox comboBox1;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
        private LinkLabel link_Register;
        private Panel PanelRegister;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private Panel panel7;
        private Label label9;
        private Panel panel6;
        private Panel panel9;
        private Label label11;
        private Panel panel8;
        private Label label10;
        private Button button2;
        private Label label12;
        private LinkLabel link_Login;
        private Button btnRegister_Click;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}
