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
    public partial class ScheduleApp : Form
    {
        internal ListofApp ListofApp;
        private BindingList<Appoiment> appoimnets;
       // private List<Pattient> patient;
        private BindingList<Doctor> doctors;
        private BindingList<Patient> patients;


        public ScheduleApp()
        {
            InitializeComponent();
            this.appoimnets = new BindingList<Appoiment>();
          this.doctors = new BindingList<Doctor>();
          this.patients = new BindingList<Patient>(); 

        }

        private void ScheduleApp_Load(object sender, EventArgs e)
        {

            patients = ClassHelper.LoadPatients();
            doctors = ClassHelper.LoadDoctors();
            appoimnets = ClassHelper.LoadAppoimnet();
            PatientCBX.DataSource = patients;
            DoctorCBX.DataSource = doctors;
        }
    

      
          

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSchedule_Click_1(object sender, EventArgs e)
        {
            if (AppID.Text.Trim() != "" | PatientCBX.SelectedIndex >= 0 || DoctorCBX.SelectedIndex >= 0 || String.IsNullOrEmpty(dateTimePicker1.Text)|| ReasonCBX.SelectedIndex>=0)
            {
                Appoiment appoiment = new Appoiment();
                DateTime time;
                
                time=dateTimePicker1.Value;
                appoiment.addAppointment(AppID.Text, time, ReasonCBX.SelectedItem.ToString(), (Patient)PatientCBX.SelectedItem, (Doctor)DoctorCBX.SelectedItem);
                //BindingList<Appoiment> appoiments = ClassHelper.LoadAppoimnet();
                appoimnets.Add(appoiment);
                ClassHelper.addScheduleOfAppToXML(new List<Appoiment>(appoimnets));
                this.Close();
            }
            
        }

        private void PatientCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

      



    }
}
