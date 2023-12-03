using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace book
{
    public partial class form3 : Form
    {
        /*        void userandoass()
                {
                    string path = @"C:\Users\sajad\source\repos\book\userpass.txt";
                    string data = username.Text + "," + password.Text + Environment.NewLine;
                    File.AppendAllText(path, data);

                }*/
        private void userandoass()
        {
            //chek fild user and pass this send
            //save and chek input user info(user pass by save txt)
            // etebar input
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                MessageBox.Show("لطفا نام کاربری را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Focus(); //control textbox typemostaghim
                return; // exit method
            }

            if (string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("لطفا رمز عبور را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Focus(); 
                return; 
            }

            // save info if true
            string path = @"C:\Users\sajad\source\repos\book\userpass.txt";
            string data = username.Text + "," + password.Text + Environment.NewLine;
            File.AppendAllText(path, data);

            MessageBox.Show("اطلاعات با موفقیت ذخیره شد.", "ذخیره سازی", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            userandoass();
        }
        void allinfo()
        {
            string path = @"C:\Users\sajad\source\repos\book\all.txt";
            string data = username.Text + "," + password.Text + "," + lastname.Text  + "," +  firstname.Text + "," + password.Text + "," + phonenumber.Text + "," + email.Text + "," + city.Text + "," + address.Text + "," + age.Text + "," + NationalId.Text + Environment.NewLine;
            if (File.Exists(path))
            {
                //delete file harbar
                File.Delete(path);
            }
            File.AppendAllText(path, data);
            
        }
        void mainuser()
        {
            //admin panel
            string path = @"C:\Users\sajad\source\repos\book\main.txt";
            string data = username.Text + "," + lastname.Text + "," + firstname.Text + "," + password.Text + Environment.NewLine;
            File.AppendAllText(path, data);
        }
        string pathglobal = "";
        public form3()
        {
            InitializeComponent();
        }

        private void backf3_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form2 form2 = new Form2(); 
            form2.Show();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "select";
            ofd.Filter = "Images (*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd.InitialDirectory = @"C:\";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get path file
                    string filePath = ofd.FileName;

                    // location image
                    imageuser.ImageLocation = filePath;

                    //save path file + txt file info 
                    SaveUserInfoWithImagePath(filePath);
            }

             void SaveUserInfoWithImagePath(string imagePath)
            {
                //save info user this path image
                
                string userInfo = $"Username: {username.Text}\nEmail: {password.Text}\nImagePath: {imagePath}";

                // delete file imgae harbar
                using (StreamWriter sw = new StreamWriter("userInfo.txt", false)) 
                {
                    //baznevisi
                    sw.WriteLine(userInfo);
                }
            }
        }
        
        private void send_Click(object sender, EventArgs e)
        {
            allinfo();
            userandoass();
            mainuser();
           
        }

        private void imageuser_Click(object sender, EventArgs e)
        {

        }
    }
}

//comment this code:
/*OpenFileDialog ofd = new OpenFileDialog();
         ofd.Title = "select";
         ofd.Filter = "Images (*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
         ofd.InitialDirectory = @"C:\";
         ofd.Multiselect = true;
         if (ofd.ShowDialog() == DialogResult.OK)
         {
             string[] files = ofd.FileNames;
             foreach (string file in files)
             {
                 imageuser.Image = Image.FromFile(ofd.FileName);
             }
         }
         pathglobal = ofd.FileName;*/
/*string path = @"C:\Users\sajad\source\repos\book\data.txt";
*//*string data = username.Text + "," + password.Text + "," + phonenumber.Text + Environment.NewLine ;
File.AppendAllText(path, data);*//*
string location = @"C:\Users\sajad\source\repos\book\image.txt";
string image = pathglobal + Environment.NewLine;
File.AppendAllText(location, image);*/