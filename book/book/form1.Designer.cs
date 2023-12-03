namespace book
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.welcome = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.welcome)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Image = global::book.Properties.Resources.welcome_dribbble;
            this.welcome.Location = new System.Drawing.Point(77, 47);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(658, 364);
            this.welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.welcome.TabIndex = 3;
            this.welcome.TabStop = false;
            // 
            // load
            // 
            this.load.Enabled = true;
            this.load.Interval = 3000;
            this.load.Tick += new System.EventHandler(this.load_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "welcome";
            ((System.ComponentModel.ISupportInitialize)(this.welcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox welcome;
        private System.Windows.Forms.Timer load;
    }
}

