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
    public  partial class ListOfPatients : Form
    {
        
        public BindingList<Person> persons;
        public BindingList<Patient> patients;
        public ListOfPatients()
        {
            InitializeComponent();
            this.persons = new BindingList<Person>();
            this.patients = new BindingList<Patient>();
           

        }

       

        private void ListOfPatients_Load(object sender, EventArgs e)
        {
            patients = ClassHelper.LoadPatients("patients.xml");
          
            dataGridView1.DataSource = patients;


        }

        
       
        private void Add_Click(object sender, EventArgs e)
        {
            Add_Patient ad = new Add_Patient();
            ad.ListOfPatients = this;
            //this.Hide();
            ad.ShowDialog();
            dataGridView1.DataSource = patients;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm form2 = new MainForm();
            form2.ListOfPatients = this;
            this.Close();
            form2.ShowDialog();

         
        }

       

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                textID.Text = row.Cells[0].Value.ToString();
                textNameF.Text = row.Cells[4].Value.ToString();
                textLastName.Text = row.Cells[5].Value.ToString();

                textIncuranceName.Text = row.Cells[1].Value.ToString();
                textNumberInsurance.Text = row.Cells[2].Value.ToString();
                textDOB.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}
