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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hide other user controls
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            //show current user control
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //hide other user controls
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            //show current user control
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //hide other user controls
            userControl21.Hide();
            userControl11.Hide();
            userControl41.Hide();
            //show current user control
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hide other user controls
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Hide();
            //show current user control
            userControl41.Show();
            userControl41.BringToFront();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Subscribing");
        }

        private void userControl41_Load(object sender, EventArgs e)
        {
            
        }

        private void cartlist_Click(object sender, EventArgs e)
        {
            
            
                
                
                }
    }
}
