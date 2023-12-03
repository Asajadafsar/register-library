namespace book
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.listView1 = new System.Windows.Forms.ListView();
            this.backf4 = new System.Windows.Forms.Button();
            this.user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.user,
            this.lastname,
            this.firstname,
            this.password});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-3, -2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(878, 369);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // backf4
            // 
            this.backf4.Image = global::book.Properties.Resources.icons8_back_96;
            this.backf4.Location = new System.Drawing.Point(771, 373);
            this.backf4.Name = "backf4";
            this.backf4.Size = new System.Drawing.Size(89, 82);
            this.backf4.TabIndex = 24;
            this.backf4.UseVisualStyleBackColor = true;
            this.backf4.Click += new System.EventHandler(this.backf4_Click);
            // 
            // user
            // 
            this.user.Text = "username:";
            // 
            // lastname
            // 
            this.lastname.Text = "lastname:";
            // 
            // firstname
            // 
            this.firstname.Text = "firstname:";
            // 
            // password
            // 
            this.password.Text = "password:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 463);
            this.Controls.Add(this.backf4);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button backf4;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader password;
    }
}