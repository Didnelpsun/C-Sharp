using System;
using System.Data.SqlClient;

namespace ChatRoom
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
