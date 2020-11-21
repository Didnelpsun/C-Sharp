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
        public static void GetAccount(User user)
        {
            SqlConnection conn = DAO.Connection();
            // 查询对应ID下的多个账户
            string queryAccount = "SELECT * FROM [Account] WHERE UserID ='" + user.UserId + "'";
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = queryAccount;
                SqlDataReader reader = command.ExecuteReader();
            }
        }
    }
}
