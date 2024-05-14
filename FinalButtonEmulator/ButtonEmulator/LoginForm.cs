using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonEmulator
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            var help1 = new ToolTip();
            help1.SetToolTip(UserPicture, "Логин");

            var help2 = new ToolTip();
            help2.SetToolTip(PassPicture, "Пароль");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SignInButton_MouseEnter(object sender, EventArgs e)
        {
            SignInButton.ForeColor = Color.Gray;
        }

        private void SignInButton_MouseLeave(object sender, EventArgs e)
        {
            SignInButton.ForeColor = Color.Black;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string login = "admin", password = "admin";

            if (LoginField.Text == login && PassField.Text == password)
            {
                MessageBox.Show("Вам доступны специальные возможности", "Вы авторизованы", MessageBoxButtons.OK);
                Close();
                Program.Form1connect.LoginUserPicture.Visible = false;
                Program.Form1connect.LoginUserPicture.Enabled = false;
                Program.Form1connect.SpecialFeaturesButton.Visible = true;
                Program.Form1connect.SpecialFeaturesButton.Enabled = true;
                Program.Form1connect.SpecialPanel.Enabled = true;
            }
            else if (LoginField.Text != login && PassField.Text != password)
            {
                message.Text = "Неверные логин и пароль";
                message.ForeColor = Color.Red;
            }
            else if (LoginField.Text != login)
            {
                message.Text = "Неверный логин";
                message.ForeColor = Color.Red;
            }
            else
            {
                message.Text = "Неверный пароль";
                message.ForeColor = Color.Red;
            }
        }
    }
}
