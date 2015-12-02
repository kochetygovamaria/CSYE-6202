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
    public partial class RemoveStudentForm : Form
    {
        internal FMstudentInfo FMstudentInfo;
        Student student;
        int index = 0;
        internal RemoveStudentForm( Student student,int index)
        {
            this.student = student;
            this.index = index;

            InitializeComponent();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do you wan tot delete a person?", "Remove student from the system", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult ==DialogResult.Yes)
            {
                FMstudentInfo.persons.RemoveAt(index);
                this.Close();
                FMstudentInfo.InitializeGreedView();
                FMstudentInfo.Show();
            }
            else
            {
                this.Close();
                FMstudentInfo.Show();
            }
           
           


        }

        private void RemoveStudentForm_Load(object sender, EventArgs e)
        {
            textFirstName.Text = student.FirstName;
            textLastName.Text = student.LastName;
            textStudentID.Text = student.StudentId;
            comboBoxDepartment.Text = student.Department;
            string enrollmentype = student.Enrolltype; 

            if (enrollmentype.ToLower().Trim() == "parttime")

            {
                radioButtonType2.Checked = true;

            }
            else
            {
                radioButtonType.Checked = true;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FMstudentInfo.Show();
        }
    }
}
