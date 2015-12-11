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
    public partial class HospitalAdmin : Form
    {
        private BindingList<Doctor> doctor;
        public HospitalAdmin(List<Person> persons, List<Doctor> doctor)
        {
            InitializeComponent();
        }
        internal HospitalAdmin(List<Doctor> doctor)
        {
            InitializeComponent();
           
            this.doctor = new BindingList<Doctor>(doctor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorList docL = new DoctorList();
            docL.ShowDialog();
        }

        private void HospitalAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
