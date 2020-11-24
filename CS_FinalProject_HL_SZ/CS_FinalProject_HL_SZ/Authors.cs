using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_FinalProject_HL_SZ
{
    public partial class Authors : Form
    {
        string connString = "Server=tcp:bcitszhl.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=Adp001;Password=Admin001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private bool mode = false;
        private int id;
        public Authors()
        {
            InitializeComponent();
            load();
        }


        private void load()
        {
            string query = $"select * from author";
            dataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2]);
            }

            conn.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.controlScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = fn.Text;
            string lastname = ln.Text;

            if(mode)
                Global.database.UpdateAuthor(firstname, lastname, id);
            else
                Global.database.CreateAuthor(firstname, lastname);
            mode = false;
            fn.Clear();
            ln.Clear();
            this.load();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                mode = true;
                string query = $"SELECT * FROM author WHERE author_id = {id}";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fn.Text = dr[1].ToString();
                    ln.Text = dr[2].ToString();
                }

                conn.Close();

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Detele"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Global.database.RemoveColumnById("author", "author_id", id);
                this.load();
            }
        }
    }
}
