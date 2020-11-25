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

        }
    }
}
