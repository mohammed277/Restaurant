using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Restaurant_accounts : Form
    {
        public Restaurant_accounts()
        {
            InitializeComponent();
            foreach (string item in casher.LS2)
            {
                listBox2.Items.Add(item);
            }
            listBox2.Items.Add("----------------------------------------------------");
            listBox2.Items.Add("Total Bill");
            foreach (int item in casher.LS4)
            {
                listBox3.Items.Add(item+"$");
            }
            listBox3.Items.Add("-----------------------");
            listBox3.Items.Add(casher.LS4.Sum()+"$");

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete f = new delete();
            f.Show();
        }
    }
}
