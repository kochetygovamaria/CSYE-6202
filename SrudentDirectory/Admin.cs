using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrudentDirectory
{
    class Admin : Person
    {
        public String UserName
        {
            get; set;
        }
       public  String Password
        {
            get; set;
        }
        public void addAdmin(string name, string last,string userName, string password) {
        FirstName = name;
        LastName = last;
        UserName =userName;
        Password=password;
        }
    }
}
