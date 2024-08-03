namespace ABC_Car_Traders
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void link_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelRegister.Height = panelMain.Height;
            panelMain.Location = new Point(368, 0);
            panel.Location = new Point(1, 0);

        }

        private void link_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelRegister.Height = 0;
            panelMain.Location = new Point(368, 0);
            panel.Location = new Point(1, 0);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
