using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChatRoom.Object;

namespace ChatRoom.Pages
{
    public partial class ChatLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            label.Text = "";
            username.Focus();
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            User user = new User(username.Text, password.Text);
            DAO.Login(user);
            switch (user.UserID)
            {
                case "1":
                    label.Text = "不存在该用户，请重新输入！";
                    break;
                case "2":
                    label.Text = "密码输入有误，请重新输入！";
                    break;
                case "3":
                    label.Text = "程序异常，请联系管理员";
                    break;
                default:
                    Session["user"] = user.UserName;
                    Response.Redirect("Chat.html");
                    break;
            }
        }
    }
}