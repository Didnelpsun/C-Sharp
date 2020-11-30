using System;
using System.Windows.Forms;
using ATM.Object;

namespace ATM.Forms
{
    public partial class AddAcount : Form
    {
        private User user;
        public AddAcount(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void AddAcount_Load(object sender, EventArgs e)
        {

        }
    }
}
