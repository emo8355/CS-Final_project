using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS_FinalProject_HL_SZ
{
    public partial class CategoryScreen : Form
    {
        int id;
        private bool mode = false;
        public CategoryScreen()
        {
            InitializeComponent(); 
        }

        private void CategoryScreen_Load(object sender, EventArgs e)
        {
            this.load();
        }

        private void load()
        {
            dataGridView1.Rows.Clear();
            List<category> categories = Global.database.GetCategories();
            foreach (category r in categories)
            {
                dataGridView1.Rows.Add(r.category_id, r.name);
            }
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            string categoryType = textBox1.Text;
            if (categoryType != "")
            {
                if (mode)
                    Global.database.UpdateCategory(categoryType, id);
                else
                    Global.database.CreateCategory(categoryType);
            }
            else
            {
                MessageBox.Show("Field can not be empty");
            }
            mode = false;
            textBox1.Clear();
            this.load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["EditCategory"].Index && e.RowIndex >= 0)
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                List<category> categories = Global.database.GetCategories(id);
                foreach (category r in categories)
                    textBox1.Text = r.name;
                mode = true;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["DeteleCategory"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Global.database.RemoveCategory( id);
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
