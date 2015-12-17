using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    public class Appoiment
    {
        public DateTime day { get; set; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        public Reason reason { get; set; }
        public String Id { get; set; }
        public void addAppointment(string Id,DateTime day, Reason reason, Patient patient, Doctor doctor)
        {

            this.day = day;
            this.reason = reason;
            this.patient = patient;
            this.doctor = doctor;
            this.Id = Id;

        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", day.ToShortDateString(),reason.ToString(), patient.ToString(), doctor.ToString());
        }



    }
}
