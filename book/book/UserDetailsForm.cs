using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace book
{
    public partial class UserDetailsForm : Form
    {

            public UserDetailsForm(string username, string[] userDetails)
            {
                InitializeComponent();
                timer1_Tick(this, EventArgs.Empty);
            string path = "C:\\Users\\sajad\\source\\repos\\book\\all.txt";
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                ListViewItem item = new ListViewItem(parts[0]);
                item.SubItems.Add(parts[1]);
                item.SubItems.Add(parts[2]);
                item.SubItems.Add(parts[4]);
                item.SubItems.Add(parts[5]);
                item.SubItems.Add(parts[6]);
                item.SubItems.Add(parts[7]);
                item.SubItems.Add(parts[8]);
                item.SubItems.Add(parts[9]);
                listView1.Items.Add(item); //add listview
            }
        }
            
        private void backf4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // read file image txt
            //timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var userInfo = File.ReadAllLines("userInfo.txt");

            // select 
            string imagePath = userInfo[2].Replace("ImagePath: ", "");
            pictureBox1.ImageLocation = imagePath;
        }
    }
    }





