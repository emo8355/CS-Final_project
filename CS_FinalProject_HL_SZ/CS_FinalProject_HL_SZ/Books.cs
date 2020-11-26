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
    public partial class Books : Form
    {
        private bool mode = false;
        private int id;
        public Books()
        {
            InitializeComponent();
            loadCategory();
            loadAuthors();
            load();
        }

        public void load()
        {
            dataGridView1.Rows.Clear();

            string query= @"
                SELECT 
                    books.book_id, 
                    books.title, 
                    books.language, 
                    category.name as category, 
                    CONCAT(author.firstname,' ',author.lastname) as fullname 
                FROM books
                    INNER JOIN category ON category.category_id =books.category_id
                    LEFT JOIN author on author.author_id = books.author_id";

            DataTable dt = Global.database.PopulateDataViewGrid(query);

            foreach (DataRow r in dt.Rows)
            {
                dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4]);
            }
        }

        public void loadCategory()
        {
            dataGridView1.Rows.Clear();

            string query = $"select * from category";
            DataTable dt = Global.database.PopulateDataViewGrid(query);
            DataSet dataset = new DataSet();
            dataset.Tables.Add(dt);

            CategorySelect.DataSource = dataset.Tables[0];
            CategorySelect.DisplayMember = "name";
            CategorySelect.ValueMember = "category_id";
        }

        public void loadAuthors()
        {
            dataGridView1.Rows.Clear();

            string query = "select author_id, CONCAT(firstname,' ',lastname) as fullname from author";
            DataTable dt = Global.database.PopulateDataViewGrid(query);
            DataSet dataset = new DataSet();
            dataset.Tables.Add(dt);

            AuthorSelect.DataSource = dataset.Tables[0];
            AuthorSelect.DisplayMember = "fullname";
            AuthorSelect.ValueMember = "author_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookTitle = bookInput.Text;
            string language = langinput.Text;
            string category = CategorySelect.SelectedValue.ToString();
            string author = AuthorSelect.SelectedValue.ToString();
            DateTime publishedDate = DateTime.Parse(dateInput.Text);

            if (bookTitle != "" || language != "" )
            {
                if (mode)
                    Global.database.UpdateBook(bookTitle, language, category, author, publishedDate, id);
                else
                    Global.database.CreateBook(bookTitle, language, category, author, publishedDate);
            }
            else
            {
                MessageBox.Show("Don't leave empty field");
            }
            
            mode = false;
            this.load();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                mode = true;
                
                string query = $"SELECT title, language, published_date FROM books WHERE book_id = {id}";
                DataTable dt = Global.database.PopulateDataViewGrid(query);

                foreach (DataRow r in dt.Rows)
                {
                    bookInput.Text = r[0].ToString();
                    langinput.Text = r[1].ToString();
                    dateInput.Text = r[2].ToString();
                }

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Detele"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Global.database.RemoveColumnById("books", "book_id", id);
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
