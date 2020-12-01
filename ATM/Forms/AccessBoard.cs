using ATM.Object;
using System;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class AccessBoard : Form
    {
        private Account account;
        private bool status;
        public AccessBoard(Account account, bool status)
        {
            InitializeComponent();
            this.account = account;
            this.status = status;
        }

        private void AccessBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
