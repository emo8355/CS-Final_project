using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS_FinalProject_HL_SZ
{
    public partial class Books : Form
    {
        private bool mode = false;
        private int id;
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            this.loadCategory();
            this.loadAuthors();
            this.load();
        }
        public void load()
        {
            dataGridView1.Rows.Clear();
            List<book> books = Global.database.GetBooks();
            foreach (book r in books)
            {
                dataGridView1.Rows.Add(
                    r.book_id, 
                    r.title, 
                    r.language, 
                    r.category.name,
                    r.author.firstname + " " + r.author.lastname);
            }
        }

        public void loadCategory()
        {
            dataGridView1.Rows.Clear();
            List<category> categories = Global.database.GetCategories();
            CategorySelect.DataSource = categories;
            CategorySelect.DisplayMember = "name";
            CategorySelect.ValueMember = "category_id";
        }

        public void loadAuthors()
        {
            dataGridView1.Rows.Clear();
            List<AuthorInfoGetter> authors = Global.database.GetAuthors(true);
            AuthorSelect.DataSource = authors;
            AuthorSelect.DisplayMember = "fullname";
            AuthorSelect.ValueMember = "author_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookTitle = bookInput.Text;
            string language = langinput.Text;
            int category = int.Parse(CategorySelect.SelectedValue.ToString());
            int author = int.Parse(AuthorSelect.SelectedValue.ToString());
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

            bookInput.Text = null;
            langinput.Text = null;
            dateInput.Text = null;
            mode = false;
            this.load();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                mode = true;
                List <book> books = Global.database.GetBooks(id);
                foreach (book r in books)
                {
                    bookInput.Text = r.title;
                    langinput.Text = r.language;
                    dateInput.Text = r.published_date.ToString();
                }

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Detele"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Global.database.RemoveBook( id);
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
