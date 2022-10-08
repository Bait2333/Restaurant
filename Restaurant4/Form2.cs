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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void cmdReg_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == String.Empty || txtPassword.Text == String.Empty || txtNumber.Text == String.Empty)
            {
                MessageBox.Show("Please enter username and password");
            }
            else if ((txtUsername.TextLength > 1 && txtUsername.TextLength < 4) || (txtPassword.TextLength > 1 && txtPassword.TextLength < 6))
            {
                MessageBox.Show("Your Username must have 4 or more characters.");
            }
            else if ((txtNumber.TextLength > 1 && txtNumber.TextLength < 10))
            {

                MessageBox.Show("Please enter a 10 digit number");

                MessageBox.Show("Successs");

            }
            else
            {

            }
            try
            {
                    string uname = txtUsername.Text;
                    string pwd = txtPassword.Text;
                    string fullname = txtFullname.Text;
                    string email = txtEmail.Text;
                    string phonenumber = txtNumber.Text;


                    User beta = new User();
                    beta.Uname = uname;
                    beta.Pwd = pwd;
                    beta.Fullname = fullname;
                    beta.Email = email;
                    beta.Phonenumber = phonenumber;

                    Form1.userlist.Add(beta);

                    MessageBox.Show("Your account has been created");

                }catch(Exception exe)
                {
                    MessageBox.Show(exe.Message);
                }
            
        }
    }
}
