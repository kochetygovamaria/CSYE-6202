using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class HospitalAdminPerson:Person
    {
        public String UserName
        {
            get; set;
        }
        public String Password
        {
            get; set;
        }

        public String AccessPoint
        {
            get; set;
        }

        public void addUser(string name, string last, string userName, string password, string Accesspoint)
        {
            FirstName = name;
            LastName = last;
            UserName = userName;
            Password = password;
            this.AccessPoint = Accesspoint;

        }

    }
}

