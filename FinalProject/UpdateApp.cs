using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalProject
{
    public partial class UpdateApp : Form
    {
        internal ListofApp ListofApp;
        private BindingList<Appoiment> appoimnets;
        private BindingList<Doctor> doctors;
        private BindingList<Patient> patients;
        int index = 0;
        public UpdateApp(Appoiment appoiment, int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void UpdateApp_Load(object sender, EventArgs e)
        {
            patients = ClassHelper.LoadPatients();
            doctors = ClassHelper.LoadDoctors();
            appoimnets = ClassHelper.LoadAppoimnet();
            AppID.Text = appoimnets[index].Id;
            PatientCBX.Text = appoimnets[index].patient.ToString();
            DoctorCBX.Text = appoimnets[index].doctor.ToString();
            dateTimePicker1.Text = appoimnets[index].day.ToShortDateString();
            ReasonCBX.Text = appoimnets[index].reason;
            DoctorCBX.DataSource = doctors;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e) {
            DateTime time;
            time = dateTimePicker1.Value;
            if (DoctorCBX.Text != this.appoimnets[index].doctor.ToString() || time != this.appoimnets[index].day || ReasonCBX.Text != this.appoimnets[index].reason)
            {
                DialogResult dialogresult = MessageBox.Show("Do you won to update  an appoimnet?", "Update an appoiment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                   // appoimnets[index].Id = AppID.Text;
                    //appoimnets[index].patient.ToString().Equals(PatientCBX);
                    appoimnets[index].doctor.ToString().Equals( DoctorCBX.Text);
                    appoimnets[index].day = time;
                    appoimnets[index].reason = ReasonCBX.Text;

                    updateAppoimnet();


                }
                this.Close();

            }
        }
          public  void updateAppoimnet()
        {
            ClassHelper.addScheduleOfAppToXML(new List<Appoiment>(appoimnets));
            
            
            
            /* XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("appoiments.xml");
            XmlNode xmlnode = xmldoc.DocumentElement.ChildNodes.Item(index);

           // xmlnode["DoctorID"].InnerText =DoctorCBX.Text;
            xmlnode["ReasonID"].InnerText = ReasonCBX.Text;
            xmlnode["Day"].InnerText = dateTimePicker1.Text;
            // save xml file and reload listview.
            xmldoc.Save("appoiments.xml");*/

        }


        //   )






        /* if (textLastName.Text != this.student.LastName ||
            textFirstName.Text != this.student.FirstName ||
            textStudentID.Text != this.student.StudentId ||
           comboBoxDepartment.SelectedItem.ToString() != this.student.Department ||
            enroll != this.student.Enrolltype)
         {
             DialogResult dialogresult = MessageBox.Show("Do you wan tot delete a person?", "Remove student from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
             if (dialogresult == DialogResult.Yes)
             {
                 student.FirstName = textFirstName.Text;
                 student.LastName = textLastName.Text;
                 student.StudentId = textStudentID.Text;
                 student.Department = comboBoxDepartment.Text;
                 student.Enrolltype = enroll;
                 FMstudentInfo.persons[index] = student;
                 this.Close();
                 FMstudentInfo.InitializeGridView();
                 FMstudentInfo.Show();
             }*/
    }
}

