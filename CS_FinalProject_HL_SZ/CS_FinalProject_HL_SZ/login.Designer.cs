namespace CS_FinalProject_HL_SZ
{
    partial class login
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
            this.Banner = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.slogan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.Psssword = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Label();
            this.Banner.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Banner.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Banner.Controls.Add(this.Title);
            this.Banner.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Banner.Location = new System.Drawing.Point(0, 1);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(1569, 110);
            this.Banner.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(40, 40, 10, 40);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1569, 110);
            this.Title.TabIndex = 1;
            this.Title.Text = "Library";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slogan
            // 
            this.slogan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slogan.AutoSize = true;
            this.slogan.Font = new System.Drawing.Font("Times New Roman", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.slogan.ForeColor = System.Drawing.SystemColors.Control;
            this.slogan.Location = new System.Drawing.Point(38, 237);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(648, 46);
            this.slogan.TabIndex = 1;
            this.slogan.Text = "Hello there, log in to read more books";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.emailInput);
            this.panel1.Controls.Add(this.Psssword);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Location = new System.Drawing.Point(414, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 445);
            this.panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 12F);
            this.textBox2.Location = new System.Drawing.Point(44, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(639, 37);
            this.textBox2.TabIndex = 6;
            // 
            // emailInput
            // 
            this.emailInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.emailInput.Font = new System.Drawing.Font("Verdana", 12F);
            this.emailInput.Location = new System.Drawing.Point(44, 102);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(639, 37);
            this.emailInput.TabIndex = 5;
            // 
            // Psssword
            // 
            this.Psssword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Psssword.AutoSize = true;
            this.Psssword.Font = new System.Drawing.Font("Verdana", 13.875F);
            this.Psssword.Location = new System.Drawing.Point(35, 199);
            this.Psssword.Name = "Psssword";
            this.Psssword.Size = new System.Drawing.Size(170, 34);
            this.Psssword.TabIndex = 4;
            this.Psssword.Text = "Password: ";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Verdana", 13.875F);
            this.email.Location = new System.Drawing.Point(35, 37);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(118, 34);
            this.email.TabIndex = 3;
            this.email.Text = "Email: ";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loginButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.loginButton.Location = new System.Drawing.Point(285, 324);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 57);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUp
            // 
            this.signUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.signUp.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signUp.Location = new System.Drawing.Point(547, 824);
            this.signUp.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(468, 23);
            this.signUp.TabIndex = 0;
            this.signUp.Text = "Don\'t have an account yet?";
            this.signUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.signUp.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1566, 944);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.slogan);
            this.Controls.Add(this.Banner);
            this.Name = "login";
            this.Text = "Form1";
            this.Banner.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Banner;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Psssword;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label signUp;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox emailInput;
    }
}

