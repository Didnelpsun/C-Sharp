using ATM.Object;
using System;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class AccountBoard : Form
    {
        private Account account;
        public AccountBoard()
        {
            InitializeComponent();
        }

        public AccountBoard(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void AccountBoard_Load(object sender, EventArgs e)
        {
            accountID.Text = account.AccountID.ToString().Trim();
            accountName.Text = account.AccountName.ToString().Trim();
            accountBank.Text = account.AccountBank.ToString().Trim();
            if (account.AccountType)
            {
                accountType.Text = "是";
            }
            else
            {
                accountType.Text = "否";
            }
            if (Convert.ToSingle(account.Balance) < 0)
            {
                this.balance.ForeColor = System.Drawing.Color.Red;
            }
            balance.Text = account.Balance.ToString();
            grade.Text = DAO.GetGradeName(account.Grade);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            User user = new User(account.UserID);
            Visible = false;
            MainFunction mainFunction = new MainFunction(user);
            mainFunction.Show();
        }
    }
}
