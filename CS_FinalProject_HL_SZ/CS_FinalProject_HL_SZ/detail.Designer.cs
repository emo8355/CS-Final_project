namespace CS_FinalProject_HL_SZ
{
    partial class detail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bannner = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allBooks = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.confirmButton = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.bannner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 110);
            this.panel1.TabIndex = 0;
            // 
            // bannner
            // 
            this.bannner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bannner.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.bannner.Location = new System.Drawing.Point(0, 0);
            this.bannner.Name = "bannner";
            this.bannner.Size = new System.Drawing.Size(1566, 110);
            this.bannner.TabIndex = 0;
            this.bannner.Text = "Search Your book";
            this.bannner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.textBox1.Location = new System.Drawing.Point(600, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 37);
            this.textBox1.TabIndex = 1;
            // 
            // searchText
            // 
            this.searchText.AutoSize = true;
            this.searchText.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.searchText.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchText.Location = new System.Drawing.Point(450, 166);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(144, 34);
            this.searchText.TabIndex = 2;
            this.searchText.Text = "Search: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1455, 482);
            this.dataGridView1.TabIndex = 3;
            // 
            // allBooks
            // 
            this.allBooks.AutoSize = true;
            this.allBooks.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.allBooks.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.allBooks.Location = new System.Drawing.Point(55, 244);
            this.allBooks.Name = "allBooks";
            this.allBooks.Size = new System.Drawing.Size(183, 34);
            this.allBooks.TabIndex = 4;
            this.allBooks.Text = "All Books: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.ForeColor = System.Drawing.Color.White;
            this.radio1.Location = new System.Drawing.Point(600, 219);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(135, 24);
            this.radio1.TabIndex = 7;
            this.radio1.TabStop = true;
            this.radio1.Text = "By book name";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.ForeColor = System.Drawing.Color.White;
            this.radio2.Location = new System.Drawing.Point(749, 219);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(102, 24);
            this.radio2.TabIndex = 8;
            this.radio2.TabStop = true;
            this.radio2.Text = "By author";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.ForeColor = System.Drawing.Color.White;
            this.radio3.Location = new System.Drawing.Point(866, 219);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(117, 24);
            this.radio3.TabIndex = 9;
            this.radio3.TabStop = true;
            this.radio3.Text = "By category";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(1375, 803);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(141, 86);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "Pick book";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(1360, 134);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(156, 66);
            this.user.TabIndex = 11;
            this.user.Text = "Go to user info";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1209, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1566, 944);
            this.Controls.Add(this.user);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allBooks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "detail";
            this.Text = "detail";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bannner;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label searchText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label allBooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}