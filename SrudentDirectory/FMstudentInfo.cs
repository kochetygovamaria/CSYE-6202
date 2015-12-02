using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SrudentDirectory
{
    internal partial class FMstudentInfo : Form
    {

        public List<Person> persons;
        public FMstudentInfo(List<Person> persons)
        {
            this.persons = persons;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxStudentInfo_Enter(object sender, EventArgs e)
        {

        }

        private void FMstudentInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                NewTempStudent();
            }
            
            
            InitializeGreedView();
            
        }  

        public void InitializeGreedView()
        {
            
            List<Student> st = new List<Student>();
            foreach (Person person in persons)
            {
                if (person is Student)
                {
                    st.Add((Student)person);


                }

            }

            dataGridView1.DataSource = st;
        }

        public void NewTempStudent()
        {
            Student student = new Student();
            bool i = true;
            while (i)
            {
                System.Threading.Thread.Sleep(50);
                try
                {
                    student = HelperClass.CreateRandom();
                    i=false;

                }
                catch (Exception ex)
                {

                    i = true;
                }
                persons.Add(student);

            }
        }
            
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                textStudentID.Text = row.Cells[0].Value.ToString();
                textFirstName.Text = row.Cells[1].Value.ToString();
                textLastName.Text= row.Cells[2].Value.ToString();
                comboBoxDepartment.Text = row.Cells[3].Value.ToString();
                //enrollment in cell infor 
                string enrollmentype = row.Cells[4].Value.ToString();
                if (enrollmentype.ToLower().Trim()=="parttime")

                {
                    radioButtonType2.Checked = true;

                }
                else
                {
                    radioButtonType.Checked = true;
                }

            }


        }


        private void buttonNewStudent_Click(object sender, EventArgs e)
        {
            
            NewStudentRegistration nsr = new NewStudentRegistration();
            nsr.FMstudentInfo = this;
            this.Hide();
            nsr.Show();
            
            
        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            int index = 0;
            Student student = null;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                foreach (Person person in persons)
                {
                    if (person is Student)
                    {
                        student = (Student)person;
                        if (student.StudentId == row.Cells[0].Value.ToString())
                        {
                            index = persons.IndexOf(person);
                            break;

                        }
                    }
                }
            }
            RemoveStudentForm rsf = new RemoveStudentForm(student, index);
            rsf.FMstudentInfo = this;
            rsf.Show();
            this.Hide();
            
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            int index = 0;
            Student student = null;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                foreach (Person person in persons)
                {
                    if (person is Student)
                    {
                        student = (Student)person;
                        if (student.StudentId == row.Cells[0].Value.ToString())
                        {
                            index = persons.IndexOf(person);
                            break;

                        }
                    }
                }
            }
            EditStudentForm esf = new EditStudentForm(student, index);
            esf.FMstudentInfo = this;
            esf.Show();
            this.Hide();
            
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
