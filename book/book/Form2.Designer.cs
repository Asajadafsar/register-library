namespace book
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.admin = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.Image = global::book.Properties.Resources.icons8_admin_cloud_96;
            this.admin.Location = new System.Drawing.Point(335, 299);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(117, 108);
            this.admin.TabIndex = 5;
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // login
            // 
            this.login.Image = global::book.Properties.Resources.icons8_login_cloud_96;
            this.login.Location = new System.Drawing.Point(335, 164);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(117, 108);
            this.login.TabIndex = 4;
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // signup
            // 
            this.signup.Image = global::book.Properties.Resources.icons8_sign_up_cloud_96;
            this.signup.Location = new System.Drawing.Point(335, 37);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(117, 108);
            this.signup.TabIndex = 3;
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.login);
            this.Controls.Add(this.signup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signup;
    }
}