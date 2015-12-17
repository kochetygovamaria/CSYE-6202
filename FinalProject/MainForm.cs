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
    public partial class MainForm : Form
    {
        internal ListOfPatients ListOfPatients;
        private BindingList<Appoiment> Appoimnet;
        private BindingList<Person> Persons;
        private BindingList<Doctor> doctor;

        public MainForm()
        {
            InitializeComponent();
        }

        internal MainForm(List<Person> persons, List<Appoiment> appoimnet,List<Doctor>doctor)
        {
            InitializeComponent();
            this.Persons = new BindingList<Person>(persons);
            this.Appoimnet = new BindingList<Appoiment>(appoimnet);
            this.doctor =new  BindingList <Doctor>( doctor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfPatients lOp = new ListOfPatients();
            lOp.ShowDialog();
        


        }

        private void buttonViewAppoimtnet_Click(object sender, EventArgs e)
        {
            ListofApp lapp = new ListofApp();
             lapp.ShowDialog();
       


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm stUF = new LoginForm();
            stUF.Show();
        }
        private void Form2_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
