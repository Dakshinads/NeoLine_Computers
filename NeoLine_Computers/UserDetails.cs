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
        string nic;
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

        public void setnic(string nic)
        {
            this.nic = nic;
        }
        public string getnic()
        {
            return nic;
        }
    }
}
