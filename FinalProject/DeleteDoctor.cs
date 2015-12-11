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
    public partial class DeleteDoctor : Form
    {
        internal DoctorList DoctorList;
        private BindingList<Doctor> doctors;
        int index = 0;
        public DeleteDoctor(Doctor doctor, int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void DeleteDoctor_Load(object sender, EventArgs e)
        {
            doctors = ClassHelper.LoadDoctors();
            textID.Text = doctors[index].ID;
            textNameF.Text = doctors[index].FirstName;
            textLastName.Text = doctors[index].LastName;
            textTitle.Text = doctors[index].Title;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do you wan tot delete a person?", "Remove   adoctor from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.Yes)
            {
                ClassHelper.deleteDoctor(doctors, index);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }


    }
}

