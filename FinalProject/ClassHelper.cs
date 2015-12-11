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

        public static BindingList<Patient> LoadPatients()
        {
            BindingList<Patient> patients = new BindingList<Patient>();
            XmlDocument doc = new XmlDocument();
            doc.Load("patients.xml");
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


        public static BindingList<Doctor> LoadDoctors()
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
            BindingList<Patient> patients = LoadPatients();
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

        public static Doctor getDoctorBYID(string id)
        {
            BindingList<Doctor> doctors = LoadDoctors();
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
                appointment.doctor = getDoctorBYID(DoctorID);
                appointment.day = Convert.ToDateTime(day);
                appointment.reason = ReasonID;


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
                xmlOut.WriteElementString("ReasonID", appoimnet.reason);


                xmlOut.WriteEndElement();
            }

            xmlOut.WriteEndElement();

            xmlOut.Close();
        }


        public static void deleteAppoiment(BindingList<Appoiment> appoimnets, int index)
        {
            /* XmlDocument xml11 = new XmlDocument();
             xml11.Load("appoiments.xml");
             XmlNodeList nodes = xml11.SelectNodes("//appoiments");
             foreach(XmlElement element in nodes){

                 element.RemoveAll();

             }
             xml11.Save("appoiments.xml");*/
            //////////////////////////////////////////////////////////
            /* XmlDocument doc = new XmlDocument();
             doc.Load("appoiments.xml");

             Appoiment toBeDeleted = appoimnets.ElementAt(index);

             XmlNodeList nodes = doc.SelectNodes("//appoiments");
             foreach (XmlElement element in nodes)
             {

                 string Id = element.ChildNodes[0].InnerText;
                 if (Id == toBeDeleted.Id)
                 {
                     doc.DocumentElement.RemoveChild(element); // i don't know if that's the right function
                     appoimnets.RemoveAt(index);
                     break;
                 }
             }
             doc.Save("appoiments.xml");

         }*/
            XmlDocument doc = new XmlDocument();
            doc.Load("appoiments.xml");
            System.Xml.XPath.XPathNavigator nav = doc.CreateNavigator();

            XPathExpression exp = nav.Compile("Input//job");
            XPathNodeIterator iter = nav.Select(exp);
            int seletedIndex = 0;
            while (iter.MoveNext())
            {
                if (iter.Current is IHasXmlNode)
                {
                    XmlNode node = ((IHasXmlNode)iter.Current).GetNode();
                    if (3 == Convert.ToInt32((node["Id"]).InnerText))
                    {
                        break;
                    }
                    seletedIndex++;
                }
            }
            XmlNode xmlnode = doc.DocumentElement.ChildNodes.Item(seletedIndex);
            xmlnode.ParentNode.RemoveChild(xmlnode);
            doc.Save("appoiments.xml");



        }

        public static void deleteDoctor(BindingList<Doctor> doctors, int index)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("doctors.xml");
            System.Xml.XPath.XPathNavigator nav = doc.CreateNavigator();

            XPathExpression exp = nav.Compile("Input//job");
            XPathNodeIterator iter = nav.Select(exp);
            int seletedIndex = 0;
            while (iter.MoveNext())
            {
                if (iter.Current is IHasXmlNode)
                {
                    XmlNode node = ((IHasXmlNode)iter.Current).GetNode();
                    if (0 == Convert.ToInt32((node["Id"]).InnerText))
                    {
                        break;
                    }
                    seletedIndex++;
                }
            }
            XmlNode xmlnode = doc.DocumentElement.ChildNodes.Item(seletedIndex);
            xmlnode.ParentNode.RemoveChild(xmlnode);
            doc.Save("doctors.xml");



        }
    }
}



