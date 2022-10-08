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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemname = label1.Text;
            string itemprice = label2.Text;
            CartList addcart = new CartList();
            addcart.Itemprice = itemprice;
            addcart.Itemname = itemname;

            


                 
           // Form3.cartlist.Text = itemname + " " + itemprice; 


        }
    }
}
