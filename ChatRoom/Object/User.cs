using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoom.Object
{
    public class User
    {
        private string userid;
        private string username;
        private string password;
        public string UserID
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
            userid = null;
            username = null;
            password = null;
        }
        public User(string id, string name, string psw)
        {
            userid = id;
            username = name;
            password = psw;
        }
        public User(string name, string psw)
        {
            userid = null;
            username = name;
            password = psw;
        }
    }
}