using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace FinalProject
{
    public class ClassHelper
    {
        public static void addDoctorXML(List<Doctor> doctors)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter xmlOut = XmlWriter.Create("doctors.xml");

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("doctors");

            foreach (Doctor d in doctors)
            {
                xmlOut.WriteStartElement("doctor");
                xmlOut.WriteElementString("Id", d.ID);
                xmlOut.WriteElementString("firstname", d.FirstName);
                xmlOut.WriteElementString("lastname", d.LastName);
                xmlOut.WriteElementString("Title", d.Title);

                xmlOut.WriteEndElement();
            }

            xmlOut.WriteEndElement();

            xmlOut.Close();
        }

        public static void addPatientToXML(List<Patient> patients)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter xmlOut = XmlWriter.Create("patients.xml");

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("patients");


            foreach (Patient p in patients)
            {
                xmlOut.WriteStartElement("patient");
                xmlOut.WriteElementString("Id", p.PatientId);
                xmlOut.WriteElementString("firstname", p.FirstName);
                xmlOut.WriteElementString("lastname", p.LastName);
                xmlOut.WriteElementString("healthProvider", p.HealthProvider);
                xmlOut.WriteElementString("healthInsuaranceN", p.InsuranceNumber);
                xmlOut.WriteElementString("dateOfBirth", p.DateOfBirth.ToShortDateString());
                xmlOut.WriteEndElement();
            }

            xmlOut.WriteEndElement();

            xmlOut.Close();
        }




        public static void addReason(List<Reason> reasons)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter xmlOut = XmlWriter.Create("reasons.xml");

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("reasons");


            foreach (Reason r in reasons)
            {
                xmlOut.WriteStartElement("reason");
                xmlOut.WriteElementString("reasonName", r.reasonName);
                xmlOut.WriteElementString("reasonPrice", r.reasonPrice.ToString());
              
                xmlOut.WriteEndElement();
            }

            xmlOut.WriteEndElement();

            xmlOut.Close();
        }

        // returns null if file not found
        public static BindingList<Patient> LoadPatients(string path)
        {
            BindingList<Patient> patients = new BindingList<Patient>();
            XmlDocument doc = new XmlDocument();

            try {
                doc.Load(path);
            }
            catch (Exception)
            {
                return null;
            }
            
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string patientId = node.ChildNodes[0].InnerText;
                string firstname = node.ChildNodes[1].InnerText;
                string lastname = node.ChildNodes[2].InnerText;
                string healthProvider = node.ChildNodes[3].InnerText;
                string healthInsuaranceN = node.ChildNodes[4].InnerText;
                string dateOfBirth = node.ChildNodes[5].InnerText;

                Patient p = new Patient();
                DateTime oDate = Convert.ToDateTime(dateOfBirth);
                p.addPatient(firstname, lastname, patientId, healthProvider, healthInsuaranceN, oDate);

                patients.Add(p);
            }
            return patients;
        }


        public static BindingList<Doctor> LoadDoctors(string path)
        {
            BindingList<Doctor> doctors = new BindingList<Doctor>();
            XmlDocument doc = new XmlDocument();
            doc.Load("doctors.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string Id = node.ChildNodes[0].InnerText;

                string firstname = node.ChildNodes[1].InnerText;
                string lastname = node.ChildNodes[2].InnerText;
                string title = node.ChildNodes[3].InnerText;
                Doctor d = new Doctor();

                d.addDoctor(firstname, lastname, Id, title);

                doctors.Add(d);
            }
            return doctors;

        }

        public static Patient getPatientByID(string id)
        {
            BindingList<Patient> patients = LoadPatients("patients.xml");
            Patient patient = null;
            //Patient patient = patients.FirstOrDefault(a => a.PatientId.Equals(id));
            foreach (Patient item in patients)
            {
                if (item.PatientId.Equals(id))
                {
                    patient = item;
                    break;
                }
            }
            return patient;
        }

        public static Doctor getDoctorByID(string id)
        {
            BindingList<Doctor> doctors = LoadDoctors("doctors.xml");
            Doctor doctor = null;
            foreach (Doctor d in doctors)
            {
                if (d.ID.Equals(id))
                {
                    doctor = d;
                    break;
                }
            }
            return doctor;

        }

        public static BindingList<Reason> LoadReason()
        {
            BindingList<Reason> reasons = new BindingList<Reason>();
            XmlDocument doc = new XmlDocument();
            doc.Load("reasons.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
               
                
                string reasonName = node.ChildNodes[0].InnerText;
                string  reasonPrice = node.ChildNodes[1].InnerText;
                Reason reason = new Reason();
                double price = Convert.ToDouble(reasonPrice);
                reason.addReason(reasonName, price);

                reasons.Add(reason);
                
            }
            return reasons;

        }

       
        public static Reason getReason(string reasonName)
        {
            BindingList<Reason> reasons = LoadReason();
           Reason reason = null;
            foreach (Reason r in reasons)
            {
                if (r.reasonName.Equals(reasonName))
                  
                {
                    reason=r;
                    break;
                }
            }
            return reason;

        }



        public static BindingList<Appoiment> LoadAppoimnet()
        {
            BindingList<Appoiment> appoimnets = new BindingList<Appoiment>();

            XmlDocument doc = new XmlDocument();
            doc.Load("appoiments.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string Id = node.ChildNodes[0].InnerText;
                string patientid = node.ChildNodes[1].InnerText;
                string DoctorID = node.ChildNodes[2].InnerText;
                string day = node.ChildNodes[3].InnerText;
                string ReasonID = node.ChildNodes[4].InnerText;

                Appoiment appointment = new Appoiment();
                appointment.Id = Id;
                appointment.patient = getPatientByID(patientid);
                appointment.doctor = getDoctorByID(DoctorID);
                appointment.day = Convert.ToDateTime(day);
                appointment.reason = getReason(ReasonID);

                appoimnets.Add(appointment);
            }
            return appoimnets;
        }
        public static void addScheduleOfAppToXML(List<Appoiment> appoimnets)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter xmlOut = XmlWriter.Create("appoiments.xml");
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("appoiments");

            foreach (Appoiment appoimnet in appoimnets)
            {
                xmlOut.WriteStartElement("appoimnet");
                xmlOut.WriteElementString("Id", appoimnet.Id);
                xmlOut.WriteElementString("patientid", appoimnet.patient.PatientId);
                xmlOut.WriteElementString("DoctorID", appoimnet.doctor.ID);
                xmlOut.WriteElementString("Day", appoimnet.day.ToShortDateString());
                xmlOut.WriteElementString("ReasonID", appoimnet.reason.reasonName);

                xmlOut.WriteEndElement();
            }

            xmlOut.WriteEndElement();

            xmlOut.Close();
        }

        public static void deleteAppoiment(BindingList<Appoiment> appoimnets, int index)
        {
            appoimnets.RemoveAt(index);
            addScheduleOfAppToXML(new List<Appoiment> (appoimnets));


        }
        public static void deleteReason(BindingList<Reason>reasons,int index)
        {
            reasons.RemoveAt(index);
            addReason(new List<Reason>(reasons));
        }

        public static void deleteDoctor(BindingList<Doctor> doctors, int index)
        {
            doctors.RemoveAt(index);
            addDoctorXML(new List<Doctor>(doctors));

        }
        public static bool UserEnteredSentinelValue(string userInput)
        {
            var result = false;
            if (userInput.Equals(null)) { result = true; }


            return result;
        }
    }
}



