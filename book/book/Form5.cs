using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book
{
    public partial class Form5 : Form
    {
        void adminpanel()
        {
            string path = @"C:\Users\sajad\source\repos\book\main.txt";
            string algoo = @"\s";
            Regex rg = new Regex(algoo);
            string[] linedata = rg.Split(File.ReadAllText(path));
            foreach (string item in linedata)
            {
                string algoo2 = @",";
                Regex rg2 = new Regex(algoo2);
                string line_deta = item;
                string[] line_deta22 = rg2.Split(line_deta);
                ListViewItem item1= new ListViewItem(line_deta22[0]);
                //search index
                for(int i=1;i< line_deta22.Length; i++)
                {
                    item1.SubItems.Add(line_deta22[i]);
                    //add domin radif
                }
                listView1.Items.Add(item1);
                //add radif
            }
        }
        public Form5()
        {
            InitializeComponent();
            adminpanel();
        }

        private void backf4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
