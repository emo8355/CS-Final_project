namespace CS_FinalProject_HL_SZ
{
    partial class user
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
            this.helloUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrowLabel = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.helloUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 110);
            this.panel1.TabIndex = 0;
            // 
            // helloUser
            // 
            this.helloUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helloUser.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.helloUser.Location = new System.Drawing.Point(0, 0);
            this.helloUser.Name = "helloUser";
            this.helloUser.Size = new System.Drawing.Size(1566, 110);
            this.helloUser.TabIndex = 0;
            this.helloUser.Text = "User";
            this.helloUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1406, 635);
            this.dataGridView1.TabIndex = 1;
            // 
            // borrowLabel
            // 
            this.borrowLabel.AutoSize = true;
            this.borrowLabel.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.borrowLabel.ForeColor = System.Drawing.Color.White;
            this.borrowLabel.Location = new System.Drawing.Point(56, 184);
            this.borrowLabel.Name = "borrowLabel";
            this.borrowLabel.Size = new System.Drawing.Size(273, 34);
            this.borrowLabel.TabIndex = 2;
            this.borrowLabel.Text = "Borrowed Books";
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.Logout.Location = new System.Drawing.Point(1319, 141);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(201, 49);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1566, 944);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.borrowLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "user";
            this.Text = "user";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label helloUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label borrowLabel;
        private System.Windows.Forms.Button Logout;
    }
}