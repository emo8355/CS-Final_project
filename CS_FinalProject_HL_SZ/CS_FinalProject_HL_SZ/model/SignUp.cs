using System;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace CS_FinalProject_HL_SZ
{
    public partial class SignUp : Form
    {
        string firstname = null;
        string lastname = null;
        string email = null;
        string password = null;
        string confirmPassword = null;
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            firstname = firstnameInput.Text;
            lastname = lastnameInput.Text;
            email = emailInput.Text;
            password = passwordInput.Text;
            confirmPassword = confirmpasswordInput.Text;

            if(password == confirmPassword)
            {

                try
                {
                    Global.database.CreateUser(firstname, lastname, email, password);
                    this.Hide();
                    Global.controlScreen.Show();
                } 
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                 
            }
            else
            {
                MessageBox.Show("Password does not match");
            }
            
        }
    }
}
