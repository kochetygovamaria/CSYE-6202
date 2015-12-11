using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Person
    {
        public String FirstName
        {
            get; set;
        }
        public String LastName
        {
            get; set;
        }
        public Person()
        { }

        public Person(string firstName, string lastname)
        {

            FirstName = firstName;
            LastName = lastname;
        }
    }
}
