namespace CS_FinalProject_HL_SZ
{
    partial class Control
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
            this.CategoryNavigate = new System.Windows.Forms.Button();
            this.AuthorsNavigate = new System.Windows.Forms.Button();
            this.BooksNavigate = new System.Windows.Forms.Button();
            this.LendBooksNavigate = new System.Windows.Forms.Button();
            this.ReturnBooksNavigate = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryNavigate
            // 
            this.CategoryNavigate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CategoryNavigate.Font = new System.Drawing.Font("Verdana", 12F);
            this.CategoryNavigate.Location = new System.Drawing.Point(184, 159);
            this.CategoryNavigate.Name = "CategoryNavigate";
            this.CategoryNavigate.Size = new System.Drawing.Size(184, 58);
            this.CategoryNavigate.TabIndex = 0;
            this.CategoryNavigate.Text = "Category";
            this.CategoryNavigate.UseVisualStyleBackColor = false;
            this.CategoryNavigate.Click += new System.EventHandler(this.CategoryNavigate_Click);
            // 
            // AuthorsNavigate
            // 
            this.AuthorsNavigate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AuthorsNavigate.Font = new System.Drawing.Font("Verdana", 12F);
            this.AuthorsNavigate.Location = new System.Drawing.Point(184, 289);
            this.AuthorsNavigate.Name = "AuthorsNavigate";
            this.AuthorsNavigate.Size = new System.Drawing.Size(184, 58);
            this.AuthorsNavigate.TabIndex = 1;
            this.AuthorsNavigate.Text = "Authors";
            this.AuthorsNavigate.UseVisualStyleBackColor = false;
            this.AuthorsNavigate.Click += new System.EventHandler(this.AuthorsNavigate_Click);
            // 
            // BooksNavigate
            // 
            this.BooksNavigate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BooksNavigate.Font = new System.Drawing.Font("Verdana", 12F);
            this.BooksNavigate.Location = new System.Drawing.Point(184, 415);
            this.BooksNavigate.Name = "BooksNavigate";
            this.BooksNavigate.Size = new System.Drawing.Size(184, 58);
            this.BooksNavigate.TabIndex = 2;
            this.BooksNavigate.Text = "Books";
            this.BooksNavigate.UseVisualStyleBackColor = false;
            this.BooksNavigate.Click += new System.EventHandler(this.BooksNavigate_Click);
            // 
            // LendBooksNavigate
            // 
            this.LendBooksNavigate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LendBooksNavigate.Font = new System.Drawing.Font("Verdana", 12F);
            this.LendBooksNavigate.Location = new System.Drawing.Point(184, 541);
            this.LendBooksNavigate.Name = "LendBooksNavigate";
            this.LendBooksNavigate.Size = new System.Drawing.Size(184, 58);
            this.LendBooksNavigate.TabIndex = 3;
            this.LendBooksNavigate.Text = "Lend book";
            this.LendBooksNavigate.UseVisualStyleBackColor = false;
            this.LendBooksNavigate.Click += new System.EventHandler(this.LendBooksNavigate_Click);
            // 
            // ReturnBooksNavigate
            // 
            this.ReturnBooksNavigate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReturnBooksNavigate.Font = new System.Drawing.Font("Verdana", 12F);
            this.ReturnBooksNavigate.Location = new System.Drawing.Point(184, 674);
            this.ReturnBooksNavigate.Name = "ReturnBooksNavigate";
            this.ReturnBooksNavigate.Size = new System.Drawing.Size(184, 58);
            this.ReturnBooksNavigate.TabIndex = 4;
            this.ReturnBooksNavigate.Text = "Return book";
            this.ReturnBooksNavigate.UseVisualStyleBackColor = false;
            this.ReturnBooksNavigate.Click += new System.EventHandler(this.ReturnBooksNavigate_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LogoutButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.LogoutButton.Location = new System.Drawing.Point(184, 806);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(184, 58);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 100);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(563, 944);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ReturnBooksNavigate);
            this.Controls.Add(this.LendBooksNavigate);
            this.Controls.Add(this.BooksNavigate);
            this.Controls.Add(this.AuthorsNavigate);
            this.Controls.Add(this.CategoryNavigate);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CategoryNavigate;
        private System.Windows.Forms.Button AuthorsNavigate;
        private System.Windows.Forms.Button BooksNavigate;
        private System.Windows.Forms.Button LendBooksNavigate;
        private System.Windows.Forms.Button ReturnBooksNavigate;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}