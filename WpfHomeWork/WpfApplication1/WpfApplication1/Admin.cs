using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Admin : Person
    {
        public string Username
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }

        public void addAdmin(string firstname, string lastname, string username, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            Username = username;
            Password = password;
        }

    }
}

