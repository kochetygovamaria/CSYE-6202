using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public class Doctor : Person
    {
        public String ID { get; set; }
        public String Title { get; set; }

        public Doctor()
        { }

        public void addDoctor(string firstname, string lastname, string id, string title)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
            Title = title;
            
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}", LastName, FirstName);
        }
    }
}
