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
    public partial class Add_Patient : Form
    {
        // public XmlDocument patients;

        internal ListOfPatients ListOfPatients;
        public Add_Patient()
        {
            InitializeComponent();
            // patients = new XmlDocument();


        }


        private void Add_Patient_Load(object sender, EventArgs e)
        {


        }

        private void buttonResert_Click(object sender, EventArgs e)
        {
            textNameF.Text = "";
            textLastName.Text = "";
            textID.Text = "";
            textIncuranceName.Text = "";
            textNumberInsurance.Text = "";
            textDOB.Text = "";


            buttonAdd.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (textNameF.Text.Trim() != "" && textLastName.Text.Trim() != "" && textID.Text.Trim() != ""
            && textIncuranceName.Text.Trim() != "" && textNumberInsurance.Text.Trim() != "" && textDOB.Text.Trim() != "")
            {
                Patient patient = new Patient();
                DateTime oDate = Convert.ToDateTime(textDOB.Text);//-There is a problem
                patient.addPatient(textNameF.Text, textLastName.Text, textID.Text,
                textIncuranceName.Text, textNumberInsurance.Text, oDate);

                ListOfPatients.patients.Add(patient);
                ClassHelper.addPatientToXML(new List<Patient>(ListOfPatients.patients));


                this.Close();
            }



        }
    }
}






    

