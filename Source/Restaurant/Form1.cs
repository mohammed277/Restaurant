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
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamReader sr;
        
        
        public Form1()
        {
            InitializeComponent();
        }
        public bool cFound=false;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //menu m = new menu();
            //m.Show();
            if (radioButton1.Checked)
            {
                instructor I = new instructor();
                if (textBox1.Text == I.Username)
                {
                    if (textBox2.Text == I.Password)
                    {
                        Restaurant_accounts r = new Restaurant_accounts();
                        r.Show();
                    }
                    else
                    {
                        MessageBox.Show("check your password", "error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("check your username", "error", MessageBoxButtons.OK);
                }
            }
            else if (radioButton2.Checked)
            {

                /* casher c = new casher();
                 c.Username = textBox1.Text;
                 c.Password = textBox2.Text;

                 foreach (casher ca in casher.LS)
                 {
                     if (ca.Username == c.Username)
                     {
                         if (ca.Password == c.Password)
                         {
                             cFound = true;
                             break;
                         }
                         else
                         {
                             cFound = false;
                         }
                     }
                     else
                     {
                         cFound = false;
                         continue;
                     }
                 }
             }*/




                /*fs = new FileStream(@"login.txt", FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    fs.Seek(0, SeekOrigin.Begin);
                    string line;
                    string[] s;
                    while ((line=sr.ReadLine())!=null)
                    {
                        s = line.Split('|');
                        if (s[0] == textBox1.Text)
                        {
                            if (s[1]==textBox2.Text)
                            {
                                cFound = true;
                                break;
                            }
                            else
                            {
                                cFound = false;
                            }
                        }
                        else
                        {
                            cFound = false;
                            continue;
                        }
                    }*/
                using (SqlConnection con = new SqlConnection(DB_clasee.connectionstring))
                {

                    SqlCommand cmd = new SqlCommand("select username,Password from tblcasher", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (textBox1.Text.Equals(dr["username"].ToString())&& textBox2.Text.Equals(dr["password"].ToString()))
                        {
                            //MessageBox.Show(dr["username"].ToString());
                            cFound = true;
                            break;
                        }
                    }
                }
                if (cFound == true)
                {
                    cFound = false;
                    menu t = new menu();
                    t.Show();
                }
                else
                {
                    MessageBox.Show("Wrong input");
                    
                }
            }
            else
            {
                MessageBox.Show("Choose Instructor or Casher");
            }

        }
        
            
        private void button2_Click(object sender, EventArgs e)
        {
         Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

