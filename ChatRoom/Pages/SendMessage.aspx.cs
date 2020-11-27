using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChatRoom.Pages
{
    public partial class SendMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = "发言人：" + Session["user"];
            if (!IsPostBack)
            {
                Application["Message"] += Session["user"] + "进入聊天室<br/>";
            }
        }

        protected void btnSent_Click(object sender, EventArgs e)
        {
            Application.Lock();
            Application["Message"] += Session["user"] + "说：" + txtMessage.Text + "(" + DateTime.Now.ToString() + ")<br/>";
            Application.UnLock();
            txtMessage.Text = "";
        }
    }
}