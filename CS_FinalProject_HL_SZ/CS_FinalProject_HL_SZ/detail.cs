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
    public partial class detail : Form
    {

        public detail()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nich reading");
        }

        private void user_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Global.userScreen.Show();
        }
    }
}
