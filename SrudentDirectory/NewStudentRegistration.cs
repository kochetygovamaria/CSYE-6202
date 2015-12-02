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
    
    public partial class NewStudentRegistration : Form
    {
        internal FMstudentInfo FMstudentInfo;
        public NewStudentRegistration()
        {
            InitializeComponent();
        }

        private void NewStudentRegistration_Load(object sender, EventArgs e)
        {
            buttonAdd.Enabled = false;
            buttonResert.Enabled = false;
        }
        private void EnableResetBurron(object sender, EventArgs e)
        {
            buttonResert.Enabled = true;
            if (textStudentID.Text.Trim() != "" && textFirstName.Text.Trim() != "" && textLastName.Text.Trim() != ""
           && comboBoxDepartment.SelectedIndex > 0)
            {
                buttonAdd.Enabled = true;
            }
        }

        private void buttonResert_Click(object sender, EventArgs e)
        {
            textStudentID.Text="";
            textFirstName.Text = "";
            textLastName.Text = "";
            comboBoxDepartment.SelectedIndex = 0;
            radioButtonType.Checked = true;
            buttonAdd.Enabled = false;
        }
       

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textStudentID.Text.Trim()!=""&& textFirstName.Text.Trim() != "" && textLastName.Text.Trim() != ""
            && comboBoxDepartment.SelectedIndex> 0)
            {
                string enroll;
                if(radioButtonType.Checked)

                {
                    enroll = "Full Time";
                }
                else
                {
                    enroll = "Part Time";
                }
                Student student = new Student();
                student.addStudent(textStudentID.Text , textFirstName.Text,textLastName.Text, comboBoxDepartment.SelectedItem.ToString(), enroll );
                
                
                FMstudentInfo.persons.Add(student);
                this.Hide();
                FMstudentInfo.InitializeGreedView();
                FMstudentInfo.Show();
                
                

            }
            else
            {
                MessageBox.Show("Please fill all infor");
            }
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
