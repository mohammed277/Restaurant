using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace Restaurant
{
    public partial class Register : Form
    {
        FileStream fs;
        StreamWriter sw;
       
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            casher c = new casher();
            c.Username = textBox1.Text;
            c.Password = textBox2.Text;
            instructor I = new instructor();
            if (textBox3.Text == I.Username)
            {
                if (textBox4.Text == I.Password)
                {
                    //casher.addcasher(c);



                    /*fs = new FileStream(@"login.txt", FileMode.Append, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine(textBox1.Text + "|" + textBox2.Text);
                    MessageBox.Show("Back to main to login", "Register completed", MessageBoxButtons.OK);
                    sw.Flush();
                    sw.Close();*/

                    using (SqlConnection con = new SqlConnection(DB_clasee.connectionstring))
                    {
                        SqlCommand cmd = new SqlCommand("spaddcasher", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();

                    }


                    this.Hide();
                }
                else
                {
                    MessageBox.Show("check your password", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("check your username", "wrong", MessageBoxButtons.OK);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

