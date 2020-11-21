using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class User
    {
        private string userid;
        private string username;
        private string password;
        public ArrayList Account = new ArrayList();
        public string UserId
        {
            set
            {
                userid = value.ToString();
            }
            get
            {
                return userid;
            }
        }
        public string UserName
        {
            set
            {
                username = value.ToString();
            }
            get
            {
                return username;
            }
        }
        public string Password
        {
            set
            {
                password = value.ToString();
            }
            get
            {
                return password;
            }
        }
        public User()
        {
            userid = "";
            username = "";
            password = "";
            Account = null;
        }
    }
}
