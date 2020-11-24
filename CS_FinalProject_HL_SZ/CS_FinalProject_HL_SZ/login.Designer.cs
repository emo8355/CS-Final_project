namespace CS_FinalProject_HL_SZ
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.Pssswordlabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
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
            this.Banner.Size = new System.Drawing.Size(881, 110);
            this.Banner.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(40, 40, 10, 40);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(881, 110);
            this.Title.TabIndex = 1;
            this.Title.Text = "Library";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.passwordInput);
            this.panel1.Controls.Add(this.emailInput);
            this.panel1.Controls.Add(this.Pssswordlabel);
            this.panel1.Controls.Add(this.emaillabel);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Location = new System.Drawing.Point(170, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 494);
            this.panel1.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.passwordInput.Font = new System.Drawing.Font("Verdana", 12F);
            this.passwordInput.Location = new System.Drawing.Point(44, 262);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(455, 37);
            this.passwordInput.TabIndex = 6;
            // 
            // emailInput
            // 
            this.emailInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.emailInput.Font = new System.Drawing.Font("Verdana", 12F);
            this.emailInput.Location = new System.Drawing.Point(44, 102);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(455, 37);
            this.emailInput.TabIndex = 5;
            // 
            // Pssswordlabel
            // 
            this.Pssswordlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pssswordlabel.AutoSize = true;
            this.Pssswordlabel.Font = new System.Drawing.Font("Verdana", 13.875F);
            this.Pssswordlabel.Location = new System.Drawing.Point(35, 199);
            this.Pssswordlabel.Name = "Pssswordlabel";
            this.Pssswordlabel.Size = new System.Drawing.Size(170, 34);
            this.Pssswordlabel.TabIndex = 4;
            this.Pssswordlabel.Text = "Password: ";
            // 
            // emaillabel
            // 
            this.emaillabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Verdana", 13.875F);
            this.emaillabel.Location = new System.Drawing.Point(35, 37);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(118, 34);
            this.emaillabel.TabIndex = 3;
            this.emaillabel.Text = "Email: ";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loginButton.Font = new System.Drawing.Font("Verdana", 12F);
            this.loginButton.Location = new System.Drawing.Point(202, 363);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(138, 57);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // signUp
            // 
            this.signUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUp.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.signUp.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signUp.Location = new System.Drawing.Point(213, 772);
            this.signUp.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(468, 23);
            this.signUp.TabIndex = 0;
            this.signUp.Text = "Don\'t have an account yet?";
            this.signUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.signUp.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(878, 944);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Banner);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Banner.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Banner;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Pssswordlabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label signUp;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox emailInput;
    }
}

