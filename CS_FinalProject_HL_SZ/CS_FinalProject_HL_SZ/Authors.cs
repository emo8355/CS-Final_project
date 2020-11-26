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
    public partial class Authors : Form
    {
        private bool mode = false;
        private int id;
        public Authors()
        {
            InitializeComponent();
            load();
        }


        private void load()
        {
            dataGridView1.Rows.Clear();
            string query = $"select * from author";
            DataTable dt = Global.database.PopulateDataViewGrid(query);
            foreach (DataRow r in dt.Rows)
            {
                dataGridView1.Rows.Add(r[0], r[1], r[2]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = fn.Text;
            string lastname = ln.Text;

            if(firstname != "" && lastname != "")
            {
                if (mode)
                    Global.database.UpdateAuthor(firstname, lastname, id);
                else
                    Global.database.CreateAuthor(firstname, lastname);
            }
            else
            {
                MessageBox.Show("Field can not be empty");
            }
            
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
                DataTable dt = Global.database.PopulateDataViewGrid(query);
                foreach (DataRow r in dt.Rows)
                {
                    fn.Text = r[1].ToString();
                    ln.Text = r[2].ToString();
                }

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Detele"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Global.database.RemoveColumnById("author", "author_id", id);
                this.load();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.controlScreen.Show();
        }
    }
}
