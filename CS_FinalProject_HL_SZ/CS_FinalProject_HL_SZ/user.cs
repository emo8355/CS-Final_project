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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.loginScreen.Show();
        }
    }
}
