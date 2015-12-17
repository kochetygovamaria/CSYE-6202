using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Patient : Person
    {
        public String PatientId { get; set; }
        public String HealthProvider { get; set; }
        public String InsuranceNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        List<Appoiment> patientAppointment = new List<Appoiment>();

        public Patient()
        { }

        // public HealthRecord Healthrecord { get; set; }
        public void addPatient(string firstname, string lastname, string patientId, string healthProvider, string healthInsuaranceN, DateTime dateOfBirth)
        {
            FirstName = firstname;
            LastName = lastname;
            PatientId = patientId;
            HealthProvider = healthProvider;
            InsuranceNumber = healthInsuaranceN;
            DateOfBirth = dateOfBirth;
        }

        public  static int Age(DateTime DateOfBirth)
        {
           int age = DateTime.Now.Year-DateOfBirth.Year;
            if ((DateOfBirth.Month > DateTime.Now.Month) || (DateOfBirth.Month == DateTime.Now.Month && DateOfBirth.Day > DateTime.Now.Day))
                age--;

            return age;

        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", LastName, FirstName);
        }
    }
}
