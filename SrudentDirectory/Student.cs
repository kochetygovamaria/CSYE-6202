using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrudentDirectory
{
    class Student:Person
    {
        
        public String StudentId
        {
            get; set;
        }
       public  String Department {
          get; set;
        }
        public String Enrolltype
        {
            get; set;
        }
        public void addStudent(string firstnmae, string lastname,string studentid, string department, string enroll)
        {
            FirstName = firstnmae;
            LastName = lastname;
            StudentId = studentid;
            Department = department;
            Enrolltype = enroll;
        }
        public void removeStudent(string firstnmae, string lastname, string studentid, string department, string enroll)
        {


}
}
}
