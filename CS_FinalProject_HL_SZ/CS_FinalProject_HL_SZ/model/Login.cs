using System;
using System.Windows.Forms;

namespace CS_FinalProject_HL_SZ
{
    public partial class Login : Form
    {
        string email = string.Empty;
        string password = string.Empty;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.email = emailInput.Text;
            this.password = passwordInput.Text;
            bool isCorrect = Global.database.LoginUser(email, password);
            if (email != "" && password != "" && isCorrect)
            {
                this.Hide();
                Global.controlScreen.Show();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password, try again");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.signUpScreen.Show();
        }
    }
}
