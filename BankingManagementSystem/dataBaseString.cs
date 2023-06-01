using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    internal class dataBaseString
    {
     const string connection =  @"Data Source=DESKTOP-1VM4CU7\SQLEXPRESS;Initial Catalog=BankDb;Integrated Security=True";

       static public string Connection
        {
            get { return connection; }
        }


        //static public string Sql
        // {
        //     get { return sql; }
        //     set { sql = value; }
        // }




    }
}
