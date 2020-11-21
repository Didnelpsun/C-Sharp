using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Object;

namespace ATM
{
    partial class DAO
    {
        public static void GetAccount(User user)
        {
            SqlConnection conn = DAO.Connection();
            // 查询对应ID下的多个账户
            string queryAccount = "SELECT * FROM [Account] WHERE UserID ='" + user.UserId + "'";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryAccount, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Accound");
                conn.Close();
                Console.WriteLine(dataSet);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
            }
        }
    }
}
