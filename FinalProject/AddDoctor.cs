using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddDoctor : Form
    {
        internal DoctorList DoctorList;
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textNameF.Text.Trim() != "" && textLastName.Text.Trim() != "" && textID.Text.Trim() != ""
           && textTitle.Text.Trim() != "")
            {
                Doctor doctor = new Doctor();
           
                doctor.addDoctor(textNameF.Text, textLastName.Text, textID.Text,
                textTitle.Text);

                DoctorList.doctors.Add(doctor);
                

                ClassHelper.addDoctorXML(new List<Doctor>(DoctorList.doctors));


                this.Close();
            }



        }

        private void textDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumberInsurance_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIncuranceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void InsuranceNumber_Click(object sender, EventArgs e)
        {

        }

        private void healthProvider_Click(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNameF_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResert_Click(object sender, EventArgs e)
        {
            textNameF.Text = "";
            textLastName.Text = "";
            textID.Text = "";
            textTitle.Text = "";
           


            buttonAdd.Enabled = false;
        }
    

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
