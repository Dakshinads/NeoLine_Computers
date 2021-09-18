using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoLine_Computers
{
    class UserDetails
    {
        string userName;
        string userRole;
        public UserDetails()
        {

        }

        public void setUserName(string username)
        {
            this.userName = username;
        }

        public string getUserName()
        {
            return userName;
        }

        public void setUserRole(string userrole)
        {
            this.userRole = userrole;
        }
        public string getUserRole()
        {
            return userRole;
        }
    }
}
