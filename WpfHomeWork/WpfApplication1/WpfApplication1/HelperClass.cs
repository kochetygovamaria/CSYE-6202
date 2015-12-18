using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class HelperClass:Student
    { 
        public static Student CreateRandom(int i)
        {
            Student student = new Student();
            Random random = new Random();
            int index = random.Next(2, 20);
            student.FirstName = RandomString(index);
            student.LastName = RandomString(index);
            int sId = random.Next(100000000, 999999999);
            string studentId = sId.ToString();
            studentId.Insert(3, "-");
            studentId.Insert(6, "-");
            student.StudentId = studentId;
            //Generate random, name and id

            string[] Department = { "Information System" , "Nursing","International Affairs",
         "Pharmacy","Professional Studies","Psycology","Public Administration"};
            int departmentindex = random.Next(0, 6);
            student.Department = (Department[departmentindex]);

            string[] erollmentType = { "Full Time", "Part Time" };
            int enrollindex = random.Next(0, 1);
            student.Enrolltype = (erollmentType[enrollindex]);
            return student;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

