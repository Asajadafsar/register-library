using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Diagnostics.Eventing.Reader;

namespace book
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void backf4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void sendlogin_Click(object sender, EventArgs e)
        {
            string username2 = username.Text;
            string password2 = password.Text;
            string path = "C:\\Users\\sajad\\source\\repos\\book\\userpass.txt";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == username2 && parts[1] == password2)
                    {
                        //send info this user this form
                        UserDetailsForm detailsForm = new UserDetailsForm(parts[0], parts.Skip(1).ToArray());
                        detailsForm.Show();
                        this.Hide();
                        return; //ok login
                    }
                }
                MessageBox.Show("نام کاربری یا رمز عبور صحیح نیست.");
            }
            else
            {
                MessageBox.Show("فایل کاربران پیدا نشد.");
            }

        }
    }
}







//send login
/*string check = username.Text + "," + password.Text;
           string path = @"C:\Users\sajad\source\repos\book\userpass.txt";
           string data = File.ReadAllText(path);
           string algoo = @"\s";
           Regex rg = new Regex(algoo);
           string[] linedata = rg.Split(data);
          //MessageBox.Show(check);
           //MessageBox.Show(linedata[0]);
           //MessageBox.Show(linedata[1]);
           for (int i = 0; i < linedata.Length; i += 2)
           {

               if (check == linedata[i])
               {
                   Form6 form = new Form6();
                   form.Show();
                   this.Hide();
                   return;
               }
           }
               MessageBox.Show("User name or pass not found ,,,MyDear");
       }

   }*/










