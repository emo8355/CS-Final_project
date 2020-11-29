using System;
using System.Collections.Generic;
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
            
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            this.load();
        }


        private void load()
        {
            dataGridView1.Rows.Clear();
            List<AuthorInfoGetter> authors = Global.database.GetAuthors(false);
            foreach (AuthorInfoGetter r in authors)
            {
                dataGridView1.Rows.Add(
                    r.author_id, 
                    r.firstname, 
                    r.lastname);
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

                List<AuthorInfoGetter> authors = Global.database.GetAuthors(id);

                foreach (AuthorInfoGetter r in authors)
                {
                    fn.Text = r.firstname;
                    ln.Text = r.lastname;
                }

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Detele"].Index && e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Global.database.RemoveAuthor(id);
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
