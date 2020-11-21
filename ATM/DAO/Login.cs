using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    partial class DAO
    {
        // 返回UserID
        public static void Login(User user)
        {
            SqlConnection conn = DAO.Connection();
            // 查询账户是否存在
            string queryUser = "SELECT UserID FROM [User] WHERE UserName='" + user.UserName + "'";
            // 查询账户密码是否一致
            string queryPass = "SELECT UserID FROM [User] WHERE UserName='" + user.UserName + "'AND Password='" + user.Password + "'";
            try
            {
                // 打开数据链接
                conn.Open();
                //Console.WriteLine("检查用户名{0}是否存在...", user.UserName);
                // 新建一个命令对象
                SqlCommand command = conn.CreateCommand();
                // 写入SQL语句
                command.CommandText = queryUser;
                // 读取对应的结果集
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    reader.Close();
                    conn.Close();
                    user.UserId = "1";
                }
                else
                {
                    // 关闭上一个读取
                    reader.Close();
                    // 验证密码
                    command.CommandText = queryPass;
                    //Console.WriteLine("检查用户名{0}密码是否正确...", user.UserName);
                    reader = command.ExecuteReader();
                    if (!reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        user.UserId = "2";

                    }
                    else
                    {
                        user.UserId = reader["UserID"].ToString();
                        reader.Close();
                        conn.Close();
                    }

                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
                user.UserId = "3";
            }
        }
    }
}
