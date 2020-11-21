using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    partial class DAO
    {
        public static SqlConnection Connection()
        {
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=atm;Integrated Security=True");
        }
        public static SqlConnection Connection(String s)
        {
            return new SqlConnection(s);
        }
    }
}
