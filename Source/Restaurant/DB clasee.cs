using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public static class DB_clasee
    {
        public static string dbpath = Directory.GetCurrentDirectory() + "\\retaurant register.mdf";
        public static string connectionstring { get; set; } = @"server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbpath + ";database=retaurant register;integrated security=sspi;";
        //public static string connectionstring {get; set;} = @"server=basher\SQLEXPRESS;database=retaurant register;integrated security=sspi;";

        // this is a bug fix
        // testing modified files and push.
    }
}
