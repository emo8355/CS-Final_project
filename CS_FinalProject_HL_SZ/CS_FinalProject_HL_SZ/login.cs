using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_FinalProject_HL_SZ
{
    public partial class login : Form
    {
        Database library = new Database();

        public login()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            library.ConfirmConnect();
        }

        private void write_Click(object sender, EventArgs e)
        {
            library.testWrite();
        }

        private void read_Click(object sender, EventArgs e)
        {
            ListDictionary data =  library.testRead();
            DictionaryEntry[] dataArray = new DictionaryEntry[data.Count];
            data.CopyTo(dataArray, 0);

            string str = $"key: {dataArray[0].Key} value: {dataArray[0].Value}";
            MessageBox.Show(str);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.detailScreen.Show();
            //library.ConfirmConnect();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.signUpScreen.Show();
        }
    }
}
