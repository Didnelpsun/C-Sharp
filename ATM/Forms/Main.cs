using System;
using System.Windows.Forms;
using ATM.Object;

namespace ATM.Forms
{
    public partial class Main : Form
    {
        private readonly User user = new User();
        public Main()
        {
            InitializeComponent();
        }
        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {
            user.UserName = textBoxUser.Text.ToString();
        }
        private void TextBoxPsw_TextChanged(object sender, EventArgs e)
        {
            user.Password = textBoxPsw.Text.ToString();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            Console.WriteLine("户名{0}是在...", user.UserName);
            DAO.Login(user);
            switch (user.UserId){
                case "1":
                    MessageBox.Show("不存在该用户，请重新输入！");
                    break;
                case "2":
                    MessageBox.Show("密码输入有误，请重新输入！");
                    break;
                case "3":
                    MessageBox.Show("程序异常，请联系管理员");
                    break;
                default:
                    MainFunction mainFunction = new MainFunction(user);
                    mainFunction.Show();
                    Visible = false;
                    MessageBox.Show("欢迎" + user.UserName + "登入", "自助存取款系统");
                    break;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgetPsw_Click(object sender, EventArgs e)
        {
            Visible = false;
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }
    }
}
