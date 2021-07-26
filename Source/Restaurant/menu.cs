using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class menu : Form
    {
        List<Panel>panellist=new List<Panel> ();
        int index ;
        int total = 0;
        int total2 = 0;
        int total3 = 0;
        int total4 = 0;
        int shwps = 0;
        bool orngclickd = false;
        public menu()
        {
            InitializeComponent();
            
        }
        private void menu_Load(object sender, EventArgs e)
        {
            panellist.Add(panel1);
            panellist.Add(panel6);
            panellist[++index].BringToFront();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (index >0)
            {
                panellist[--index].BringToFront();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (index < panellist.Count - 1)
            {
                panellist[++index].BringToFront();
            }
        }
        int check1;
        private void button24_Click(object sender, EventArgs e)
        {
            if (check1 == 1)
            {
                
                total4 = total - total2;
                total -= total4;
                check1 = 0;
            }
            string s = "";
            foreach (string item in casher.LS1)
            {
                s += item + "\n";
            }
            MessageBox.Show(""+s+"\n"+ "Total Bill  "+total+"$","Order");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            bool isempty = !casher.LS1.Any();
            if (isempty)
            {
                MessageBox.Show("the order list is empty", "order");
            }
            else
            {
                casher.LS1.RemoveAt(casher.LS1.Count - 1);
                casher.LS2.RemoveAt(casher.LS2.Count - 1);
                casher.LS3.RemoveAt(casher.LS3.Count - 1);
                casher.LS4.RemoveAt(casher.LS4.Count - 1);
                total2 = casher.LS3.Sum();   
                check1= 1;         
            }
        }
        private void button23_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("divino\t13$ ");
            casher.LS2.Add("divino ");
            total +=13;
            casher.LS3.Add(13);
            casher.LS4.Add(13);
            
        }
        private void button22_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Tutti\t7$ ");
            casher.LS2.Add("Tutti ");
            total += 7;
            casher.LS3.Add(7);
            casher.LS4.Add(7);
        }
        private void button19_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Olivo\t8$ ");
            casher.LS2.Add("Olivo ");
            total += 8;
            casher.LS3.Add(8);
            casher.LS4.Add(8);
        }
        private void button21_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Papjohn\t15$");
            casher.LS2.Add("Papjohn ");
            total += 15;
            casher.LS3.Add(15);
            casher.LS4.Add(15);
        }
        private void button20_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Pepenero  10$");
            casher.LS2.Add("Pepenero ");
            total += 10;
            casher.LS3.Add(10);
            casher.LS4.Add(10);
        }

        private void button18_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("crudo\t18$");
            casher.LS2.Add("crudo ");
            total += 18;
            casher.LS3.Add(18);
            casher.LS4.Add(18);
        }

        private void button17_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Pizza Hut  9$");
            casher.LS2.Add("Pizza Hut ");
            total += 9;
            casher.LS3.Add(9);
            casher.LS4.Add(9);
        }
        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Mandarin  9$");
            casher.LS2.Add("Mandarin ");
            total += 9;
            casher.LS3.Add(9);
            casher.LS4.Add(9);
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Vinny\t10$");
            casher.LS2.Add("Vinny ");
            total += 10;
            casher.LS3.Add(10);
            casher.LS4.Add(10);
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Aperttivo\t9$");
            casher.LS2.Add("Aperttivo ");
            total += 9;
            casher.LS3.Add(9);
            casher.LS4.Add(9);
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Napoil\t13$");
            casher.LS2.Add("Napoil ");
            total += 13;
            casher.LS3.Add(13);
            casher.LS4.Add(13);
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("LaBomba  7$");
            casher.LS2.Add("LaBomba");
            total += 7;
            casher.LS3.Add(7);
            casher.LS4.Add(7);
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("crawen\t12$");
            casher.LS2.Add("crawen ");
            total += 12;
            casher.LS3.Add(12);
            casher.LS4.Add(12);
        }
        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("neshason  8$");
            casher.LS2.Add("neshason ");
            total += 8;
            casher.LS3.Add(8);
            casher.LS4.Add(8);
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Greek\t16$");
            casher.LS2.Add("Greek ");
            total += 16;
            casher.LS3.Add(16);
            casher.LS4.Add(16);
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Chicago\t6$");
            casher.LS2.Add("Chicago ");
            total += 6;
            casher.LS3.Add(6);
            casher.LS4.Add(6);
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Nepolitn\t9$");
            casher.LS2.Add("Nepolitn ");
            total += 9;
            casher.LS3.Add(9);
            casher.LS4.Add(9);
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Sicilian\t15$");
            casher.LS2.Add("Sicilian ");
            total += 15;
            casher.LS3.Add(15);
            casher.LS4.Add(15);

        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("tamprin\t9$");
            casher.LS2.Add("tamprin ");
            total += 9;
            casher.LS3.Add(9);
            casher.LS4.Add(9);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("shopany\t7$");
            casher.LS2.Add("shopany ");
            total += 7;
            casher.LS3.Add(7);
            casher.LS4.Add(7);
        }
        
        private void button44_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("orange\t6$");
            casher.LS2.Add("orange ");
            total += 6;
            casher.LS3.Add(6);
            casher.LS4.Add(6);
        }

        private void button43_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Aam Ras\t5$");
            casher.LS2.Add("Aam Ras ");
            total += 5;
            casher.LS3.Add(5);
            casher.LS4.Add(5);
        }

        private void button40_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("pepsi\t3$");
            casher.LS2.Add("pepsi ");
            total += 3;
            casher.LS3.Add(3);
            casher.LS4.Add(3);
        }

        private void button42_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Virgin\t8$");
            casher.LS2.Add("Virgin");
            total += 8;
            casher.LS3.Add(8);
            casher.LS4.Add(8);
        }

        private void button41_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Grape\t6$");
            casher.LS2.Add("Grape ");
            total += 6;
            casher.LS3.Add(6);
            casher.LS4.Add(6);
        }

        private void button39_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("lemon\t4$");
            casher.LS2.Add("lemon ");
            total += 4;
            casher.LS3.Add(4);
            casher.LS4.Add(4);
        }

        private void button38_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Pomgrant  3$");
            casher.LS2.Add("Pomgrant ");
            total += 3;
            casher.LS3.Add(3);
            casher.LS4.Add(3);
        }

        private void button37_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Mandrne\t6$");
            casher.LS2.Add("Mandrne ");
            total += 6;
            casher.LS3.Add(6);
            casher.LS4.Add(6);
        }

        private void button36_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Kiwi\t9$");
            casher.LS2.Add("Kiwi ");
            total += 9;
            casher.LS3.Add(9);
            casher.LS4.Add(9);
        }

        private void button35_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Lychee\t8$");
            casher.LS2.Add("Lychee ");
            total += 8;
            casher.LS3.Add(8);
            casher.LS4.Add(8);
        }

        private void button34_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Ananas\t8$");
            casher.LS2.Add("Ananas ");
            total += 8;
            casher.LS3.Add(8);
            casher.LS4.Add(8);
        }

        private void button33_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Plumnes\t7$");
            casher.LS2.Add("Plumnes ");
            total += 7;
            casher.LS3.Add(7);
            casher.LS4.Add(7);
        }

        private void button32_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("Berry\t9$");
            casher.LS2.Add("Berry ");
            total += 9;
            casher.LS3.Add(9);
            casher.LS4.Add(9);
        }

        private void button31_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("W.melon\t9$");
            casher.LS2.Add("W.melon ");
            total += 9;
            casher.LS3.Add(9);
            casher.LS4.Add(9);
        }

        private void button30_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("sprite\t4$");
            casher.LS2.Add("sprite ");
            total += 4;
            casher.LS3.Add(4);
            casher.LS4.Add(4);
        }

        private void button29_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("cocacola\t4$");
            casher.LS2.Add("cocacola ");
            total += 4;
            casher.LS3.Add(4);
            casher.LS4.Add(4);
        }

        private void button28_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("fanta\t4$");
            casher.LS2.Add("fanta ");
            total += 4;
            casher.LS3.Add(4);
            casher.LS4.Add(4);
        }

        private void button27_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("lipton\t3$");
            casher.LS2.Add("lipton ");
            total += 3;
            casher.LS3.Add(3);
            casher.LS4.Add(3);
        }

        private void button26_MouseClick(object sender, MouseEventArgs e)
        {
            casher.LS1.Add("trobicana  6$");
            casher.LS2.Add("trobicana ");
            total += 6;
            casher.LS3.Add(6);
            casher.LS4.Add(6);
        }

        private void button25_MouseClick(object sender, MouseEventArgs e)
        {
            shwps++;
            casher.LS1.Add("schwpse\t4$");
            casher.LS2.Add("schwpse ");
            total += 4;
            casher.LS3.Add(4);
            casher.LS4.Add(4);
        }
        private void button45_Click(object sender, EventArgs e)
        {
            if (check1==1)
            {
                int total4 = total - total2;
                total -= total4;
                check1 = 0;
            }
            string s = "";
            foreach (string item in casher.LS1)
            {
                s += item + "\n";
            }
            MessageBox.Show("" + s + "\n" + "Total Bill " + total+"$", "Order");

        }
        
        private void button46_Click(object sender, EventArgs e)
        {
            casher.LS2.Add("-------------------------------------------------");
            casher.LS4.Add(0);
            casher.LS1.Clear();
            casher.LS3.Clear();
            total = 0;
            total2 = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button23_Click(object sender, EventArgs e)
        {
            
        }
        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}
