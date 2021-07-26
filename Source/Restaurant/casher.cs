using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class casher
    {
        string username;
        string password;
        public static List<casher> LS=new List<casher>();
        public static List<string> LS1 = new List<string>();//print order in message box
        public static List<string> LS2 = new List<string>();//print order in restaurant accunts 
        public static List<int> LS3 = new List<int>();//print total bill of restaurant accunts 
        public static List<int> LS4 = new List<int>();//print price on restaurant accounts
        public casher(string U,string P)
        {
            Username = U;
            Password = P;
        }
        public casher() { }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        public static void addcasher(casher c)
        {
            LS.Add(c);
        }
       
       
    }

    class instructor
    {
        string _username;
        string _password;
        public instructor()
        {
            Username = "123";
            Password = "123";
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
    }
}
