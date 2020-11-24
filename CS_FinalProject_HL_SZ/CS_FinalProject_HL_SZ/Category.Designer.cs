namespace CS_FinalProject_HL_SZ
{
    partial class Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.GroupBox();
            this.AddCategory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCategory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeteleCategory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.categoryBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.categoryBox.Controls.Add(this.AddCategory);
            this.categoryBox.Controls.Add(this.textBox1);
            this.categoryBox.Controls.Add(this.label2);
            this.categoryBox.Location = new System.Drawing.Point(49, 185);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(437, 387);
            this.categoryBox.TabIndex = 1;
            this.categoryBox.TabStop = false;
            this.categoryBox.Text = "Category Input";
            // 
            // AddCategory
            // 
            this.AddCategory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddCategory.Location = new System.Drawing.Point(98, 263);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(209, 65);
            this.AddCategory.TabIndex = 2;
            this.AddCategory.Text = "Add";
            this.AddCategory.UseVisualStyleBackColor = false;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.textBox1.Location = new System.Drawing.Point(12, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 37);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryId,
            this.categoryName,
            this.EditCategory,
            this.DeteleCategory});
            this.dataGridView1.Location = new System.Drawing.Point(567, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 387);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoryId
            // 
            this.categoryId.HeaderText = "id";
            this.categoryId.MinimumWidth = 8;
            this.categoryId.Name = "categoryId";
            this.categoryId.Width = 150;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Category";
            this.categoryName.MinimumWidth = 8;
            this.categoryName.Name = "categoryName";
            this.categoryName.Width = 150;
            // 
            // EditCategory
            // 
            this.EditCategory.HeaderText = "Edit";
            this.EditCategory.MinimumWidth = 8;
            this.EditCategory.Name = "EditCategory";
            this.EditCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditCategory.Text = "Edit";
            this.EditCategory.UseColumnTextForButtonValue = true;
            this.EditCategory.Width = 150;
            // 
            // DeteleCategory
            // 
            this.DeteleCategory.HeaderText = "Delete";
            this.DeteleCategory.MinimumWidth = 8;
            this.DeteleCategory.Name = "DeteleCategory";
            this.DeteleCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeteleCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeteleCategory.Text = "Delete";
            this.DeteleCategory.UseColumnTextForButtonValue = true;
            this.DeteleCategory.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Verdana", 13.875F);
            this.button1.Location = new System.Drawing.Point(428, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1280, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label1);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "category";
            this.categoryBox.ResumeLayout(false);
            this.categoryBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox categoryBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewButtonColumn EditCategory;
        private System.Windows.Forms.DataGridViewButtonColumn DeteleCategory;
    }
}