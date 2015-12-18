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
    public partial class ListofApp : Form
    {
        public BindingList <Appoiment> appoimnets;
        public BindingList<Patient> patients;
        public  BindingList<Doctor> doctors;
        public BindingList<Reason> reasons;


        public ListofApp()
        {
            InitializeComponent();
            this.appoimnets = new BindingList<Appoiment>();
            this.patients = new BindingList<Patient>();
            this.doctors = new BindingList<Doctor>();
            this.reasons = new BindingList<Reason>();
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void List_of_App_Load(object sender, EventArgs e)
        {
           patients= ClassHelper.LoadPatients("patients.xml"); 
           doctors=ClassHelper.LoadDoctors("doctors.xml");
            reasons = ClassHelper.LoadReason();
            LoadDataGrid();

        }

        private void ScheduleAppoiment_Click(object sender, EventArgs e)
        {
            ScheduleApp sapp = new ScheduleApp();
            sapp.ListofApp = this;
            sapp.ShowDialog();
            LoadDataGrid();

        }

        private void AppoimentGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AppoimentGridView.SelectedRows)
            {
                AppID.Text = row.Cells[4].Value.ToString();
                PatientCBX.Text = row.Cells[1].Value.ToString();
                DoctorCBX.Text = row.Cells[2].Value.ToString();
                dateTimePicker.Text = row.Cells[0].Value.ToString();
                ReasonCBX.Text = row.Cells[3].Value.ToString();
                
            }
        }


    

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm();
            form.Show();
        }


        

    

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            int index = 0;
            Appoiment appoiment = null;
            appoimnets = ClassHelper.LoadAppoimnet();
            foreach (DataGridViewRow row in AppoimentGridView.SelectedRows)
            {
                foreach (Appoiment app in appoimnets)
                {
                    if (app.Id == row.Cells[4].Value.ToString())
                    {
                        index = appoimnets.IndexOf(app);
                        appoiment = app;
                        break;

                    }
                }
                
            }


            CancelForm cf = new CancelForm(appoiment, index);
            cf.ListofApp = this;
            cf.ShowDialog();
            LoadDataGrid();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index = 0;
            Appoiment appoiment = null;
            appoimnets = ClassHelper.LoadAppoimnet();
            foreach (DataGridViewRow row in AppoimentGridView.SelectedRows)
            {
                foreach (Appoiment app in appoimnets)
                {
                    if (app.Id == row.Cells[4].Value.ToString())
                    {
                        index = appoimnets.IndexOf(app);
                        appoiment = app;
                        break;

                    }
                }

            }


            UpdateApp upf = new UpdateApp(appoiment, index);
            upf.ListofApp = this;
            upf.ShowDialog();
            LoadDataGrid();
            
        }
        private void LoadDataGrid()
        {
            appoimnets = ClassHelper.LoadAppoimnet();
            AppoimentGridView.DataSource = appoimnets;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ReasonCBX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

    
    

