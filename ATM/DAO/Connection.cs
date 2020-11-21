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
            string connectStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=atm;Integrated Security=True";
            return new SqlConnection(connectStr);
        }
    }
}
