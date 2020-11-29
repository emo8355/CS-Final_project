using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS_FinalProject_HL_SZ
{
    public partial class LendBooks : Form
    {

        public LendBooks()
        {
            InitializeComponent();
        }

        private void LendBooks_Load(object sender, EventArgs e)
        {
            this.load();
        }

        private void load()
        {
            dataGridView1.Rows.Clear();
            List<BookInfoGetter> books = Global.database.GetBookStatus(false);
            foreach (BookInfoGetter r in books)
            {
                dataGridView1.Rows.Add(
                    r.book_id, 
                    r.title, 
                    r.language, 
                    r.category, 
                    r.author, 
                    r.status);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Lend"].Index && e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Global.database.UpdateBookStatus(true, id);
            }
            this.load();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.controlScreen.Show();
        }

        
    }
}
