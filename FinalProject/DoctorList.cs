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
    public partial class DoctorList : Form
    {
        public BindingList<Doctor> doctors;
        public DoctorList()
        {
            InitializeComponent();
            this.doctors = new BindingList<Doctor>();
        }

        private void DoctorList_Load(object sender, EventArgs e)
        {
            doctors = ClassHelper.LoadDoctors();
            dataGridViewDoctor.DataSource = doctors;
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor adD = new AddDoctor();
            adD.DoctorList = this;
            adD.ShowDialog();
            dataGridViewDoctor.DataSource = doctors;

        }

        private void dataGridViewDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                

            
        }

        private void dataGridViewDoctor_CellContentClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDoctor.SelectedRows)
            {
                textID.Text = row.Cells[2].Value.ToString();
                textNameF.Text = row.Cells[0].Value.ToString();
                textLastName.Text = row.Cells[1].Value.ToString();

                textTitle.Text = row.Cells[3].Value.ToString();


            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            int index = 0;
            Doctor doctor = null;
            doctors = ClassHelper.LoadDoctors();
            foreach (DataGridViewRow row in dataGridViewDoctor.SelectedRows)
            {
                foreach (Doctor doc in doctors)
                {
                    if (doc.ID == row.Cells[2].Value.ToString())
                    {
                        index = doctors.IndexOf(doc);
                        doctor = doc;
                        break;

                    }
                }

            }


            DeleteDoctor dD = new DeleteDoctor(doctor, index);
            dD.DoctorList = this;
            dD.ShowDialog();
            LoadDataGrid();

        }
        private void LoadDataGrid()
        {
            doctors = ClassHelper.LoadDoctors();
            dataGridViewDoctor.DataSource = doctors;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            Doctor doctor = null;
            doctors = ClassHelper.LoadDoctors();
            foreach (DataGridViewRow row in dataGridViewDoctor.SelectedRows)
            {
                foreach (Doctor doc in doctors)
                {
                    if (doc.ID == row.Cells[2].Value.ToString())
                    {
                        index = doctors.IndexOf(doc);
                        doctor = doc;
                        break;

                    }
                }

            }


            UpdateDoctor upf = new UpdateDoctor(doctor, index);
            upf.DoctorList = this;
            upf.ShowDialog();
            LoadDataGrid();
        }
    }
    }

