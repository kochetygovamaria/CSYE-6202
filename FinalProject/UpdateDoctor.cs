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
    public partial class UpdateDoctor : Form
    {
        internal DoctorList DoctorList;
        private BindingList<Doctor> doctors;
        int index = 0;
        public UpdateDoctor(Doctor doctor, int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {
            doctors = ClassHelper.LoadDoctors();
            textID.Text = doctors[index].ID;
            textNameF.Text = doctors[index].FirstName;
            textLastName.Text = doctors[index].LastName;
            textTitle.Text = doctors[index].Title;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (textID.Text != this.doctors[index].ID || textNameF.Text != this.doctors[index].FirstName || textLastName.Text != this.doctors[index].LastName || textTitle.Text != this.doctors[index].Title)
            {
                DialogResult dialogresult = MessageBox.Show("Do you want to update  an appoimnet?", "Update an doctor's info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                    doctors[index].ID = textID.Text;
                    doctors[index].FirstName = textNameF.Text;
                    doctors[index].LastName = textLastName.Text;
                    doctors[index].Title = textTitle.Text;



                    updateDoctor();


                }
                this.Close();



            }

        }
        public void updateDoctor()
        {
            ClassHelper.addDoctorXML(new List<Doctor>(doctors));
        }
    }
}

