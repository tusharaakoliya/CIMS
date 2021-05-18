using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
    public class LoginBEL
    {
        private int _userId;

        private int _roleId;

        private string _username;

        private string _password;

        private DateTime _createdDate;

        private DateTime? _lastLoginDate = null;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public int RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public DateTime? LastLoginDate
        {
            get { return _lastLoginDate; }
            set { _lastLoginDate = value; }
        }
    }
}
