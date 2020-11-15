namespace CS_FinalProject_HL_SZ
{
    partial class Form1
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
            this.connect = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(58, 48);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(266, 148);
            this.connect.TabIndex = 0;
            this.connect.Text = "test connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(58, 230);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(260, 107);
            this.write.TabIndex = 1;
            this.write.Text = "test write";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(411, 230);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(260, 107);
            this.read.TabIndex = 2;
            this.read.Text = "test read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.read);
            this.Controls.Add(this.write);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button read;
    }
}

