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
        private int id;
        private bool mode = false;
        public Category()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            dataGridView1.Rows.Clear();
            string query = "SELECT * FROM category";
            DataTable dt = Global.database.PopulateDataViewGrid(query);
            foreach (DataRow r in dt.Rows)
            {
                dataGridView1.Rows.Add(r[0], r[1]);
            }
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            string categoryType = textBox1.Text;
            if (categoryType != "")
            {
                if (mode)
                    Global.database.UpdateCategory(categoryType, Convert.ToInt32(id));
                else
                    Global.database.CreateCategory(categoryType);
            }
            else
            {
                MessageBox.Show("Field can not be empty");
            }
            textBox1.Clear();
            this.load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["EditCategory"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string query = $"SELECT * FROM category WHERE category_id = '{id}'";
                DataTable dt = Global.database.PopulateDataViewGrid(query);
                foreach (DataRow r in dt.Rows)
                {
                    textBox1.Text = r[1].ToString();
                }
                mode = true;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["DeteleCategory"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Global.database.RemoveColumnById("category", "category_id", id);
                this.load();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.controlScreen.Show();
        }
    }
}
