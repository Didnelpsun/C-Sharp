using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Object
{
    class Account
    {
        private string accountid;
        private string accountname;
        private string accountbank;
        private bool accounttype;
        private float balance;
        private int grade;
        public string AccountID
        {
            set
            {
                accountid = value.ToString();
            }
            get
            {
                return accountid;
            }
        }
        public string AccountName
        {
            set
            {
                accountname = value.ToString();
            }
            get
            {
                return accountname;
            }
        }
        public string AccountBank
        {
            set
            {
                accountbank = value.ToString();
            }
            get
            {
                return accountbank;
            }
        }
        public bool AccountType
        {
            set
            {
                accounttype = Convert.ToBoolean(value);
            }
            get
            {
                return accounttype;
            }
        }
        public float Balance
        {
            set
            {
                balance = Convert.ToSingle(value);
            }
            get
            {
                return balance;
            }
        }
        public int Grade
        {
            set
            {
                grade = Convert.ToInt16(value);
            }
            get
            {
                return grade;
            }
        }
        public Account()
        {
            accountid = null;
            accountname = null;
            accountbank = null;
            accounttype = false;
            balance = 0;
            grade = 0;
        }
    }
}
