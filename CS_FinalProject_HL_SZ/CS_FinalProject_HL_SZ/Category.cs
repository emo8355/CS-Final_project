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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            string connString = "Server=tcp:bcitszhl.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=Adp001;Password=Admin001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = $"select * from category";
            dataGridView1.Rows.Clear();
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1]);
            }
            
 
            conn.Close();
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            string categoryType = textBox1.Text;
            if (categoryType != "")
            {
                Global.database.CreateCategory(categoryType);
                textBox1.Clear();
                this.load();
            }
            else
            {
                MessageBox.Show("Field can not be empty");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.controlScreen.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["EditCategory"].Index && e.RowIndex >= 0)
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string str = textBox1.Text;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["DeteleCategory"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Global.database.RemoveColumnById("category", "category_id", id);
                this.load();
            }
        }
    }
}
