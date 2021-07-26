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
    public partial class delete : Form
    {
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        

        public bool found = false;

        public delete()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /* fs = new FileStream(@"login.txt", FileMode.Open, FileAccess.ReadWrite);
             sr = new StreamReader(fs);
             sw = new StreamWriter(fs);
             fs.Seek(0, SeekOrigin.Begin);
             fs.Flush();
             string line;
             string[] field;
             int count = 0;
             while ((line = sr.ReadLine()) != null)
             {
                 field = line.Split('|');
                 if (field[0] == textBox1.Text)
                 {
                     if (field[1]==textBox2.Text)
                     {

                         found = true;
                         break;
                     }
                     else
                     {
                         found = false;
                     }
                 }
                 else
                 {
                     found = false;
                 }
                MessageBox.Show(count.ToString());
            }
            if (found==true)
            {
                fs.Seek(count, SeekOrigin.Begin);
                fs.Flush();
                sw.Write("*");
                sw.Flush();
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("wrong input");
            }
            fs.Close();
            sr.Close();
            sw.Close();*/


            using (SqlConnection con = new SqlConnection(DB_clasee.connectionstring))
            {

                SqlCommand cmd = new SqlCommand("select username,Password from tblcasher", con);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {


                    while (dr.Read())
                    {
                        if (textBox1.Text == (dr["username"].ToString()) && textBox2.Text == (dr["password"].ToString()))
                        {
                            found = true;
                            break;
                        }

                    }
                }
            
                if (found==true)
                {
                    SqlCommand cmd1 = new SqlCommand("delete from tblcasher where username=@username and password=@password", con);
                    cmd1.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd1.Parameters.AddWithValue("@password", textBox2.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    Hide();
                }
                else
                {
                    MessageBox.Show("Wrong input");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
