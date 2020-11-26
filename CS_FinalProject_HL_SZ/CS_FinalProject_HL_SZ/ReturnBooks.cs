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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
            this.load();
        }

        private void load()
        {
            dataGridView1.Rows.Clear();
            string query = @"
                select 
                	books.book_id, 
                	books.title, 
                	books.language, 
                	category.name as category, 
                	CONCAT(author.firstname,' ',author.lastname) as fullname,
                	books.isBorrowed as status,
                    CASE WHEN books.isBorrowed = 0 THEN 'false' ELSE 'true' END AS status
                from books
                	INNER JOIN category ON category.category_id =books.category_id
                	LEFT JOIN author on author.author_id = books.author_id
                WHERE books.isBorrowed = 1";
            DataTable dt = Global.database.PopulateDataViewGrid(query);
            foreach (DataRow r in dt.Rows)
            {
                dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Return"].Index && e.RowIndex >= 0)
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Global.database.UpdateBookStatus(0, id);
            }
            this.load();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.controlScreen.Show();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            this.load();
        }
    }
}
