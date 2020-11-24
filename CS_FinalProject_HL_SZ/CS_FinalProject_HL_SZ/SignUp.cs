using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                Global.database.CreateUser(firstname, lastname, email, password);
                this.Hide();
                Global.controlScreen.Show();
            }
            else
            {
                MessageBox.Show("Password does not match");
            }
            
        }
    }
}
