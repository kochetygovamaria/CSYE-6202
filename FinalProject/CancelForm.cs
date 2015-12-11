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
    public partial class CancelForm : Form
    {
        internal ListofApp ListofApp;
        private BindingList<Appoiment> appoimnets;

        private BindingList<Doctor> doctors;
        private BindingList<Patient> patients;
        int index = 0;
        public CancelForm(Appoiment appoiment, int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void CancelForm_Load(object sender, EventArgs e)
        {

            patients = ClassHelper.LoadPatients();
            doctors = ClassHelper.LoadDoctors();
            appoimnets = ClassHelper.LoadAppoimnet();
            AppID.Text = appoimnets[index].Id;
            PatientCBX.Text = appoimnets[index].patient.PatientId;
            DoctorCBX.Text = appoimnets[index].doctor.ID;
            dateTimePicker.Text = appoimnets[index].day.ToShortDateString();
            ReasonCBX.Text = appoimnets[index].reason;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do you wan tot delete a person?", "Remove appoimnet from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.Yes)
            {
                ClassHelper.deleteAppoiment(appoimnets, index);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    
    private void AppID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


