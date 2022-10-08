using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant4
{
    public partial class Form1 : Form
    {
        public static List<User> userlist = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool islogged = false;

            for(int i = 0; i < userlist.Count; i++)
            {
                if (userlist[i].Uname == txtusername.Text && userlist[i].Pwd == txtpassword.Text)
                {
                    
                    islogged = true; break;
                }
            }

            if(islogged == false)

            {
                MessageBox.Show("Your credentials are incorrect!!");
            }
            else
            {
                this.Hide();
                // create an instance of form2
                Form3 f3 = new Form3();
                // show form2
                f3.ShowDialog(); // it gonna halt/freeze the execution of click event.
                                 // dispose form2 instance

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // hide form1
            this.Hide();
            // create an instance of form2
            Form2 f2 = new Form2();
            // show form2
            f2.ShowDialog(); // it gonna halt/freeze the execution of click event.
            // dispose form2 instance
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
