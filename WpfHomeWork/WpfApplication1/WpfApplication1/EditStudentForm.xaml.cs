using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for EditStudentForm.xaml
    /// </summary>
    public partial class EditStudentForm : Window
    {
        internal StudentInfo StudentInfo;
        Student s;
        int index = 0;
        internal EditStudentForm(Student student, int index)
        {
            InitializeComponent();
            this.s = student;
            this.index = index;

        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            StudentInfo.Show();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (IsStudentidOK(txtStudentID.Text))
            {
                MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to edit this student?", "Edit Student Registration Confirmation", MessageBoxButton.YesNo);

                if (dialogResult == MessageBoxResult.Yes)
                {
                    UpdateStudentList();
                    this.Close();
                    StudentInfo.Show();

                }
                else if (dialogResult == MessageBoxResult.No)
                    this.Close();
                StudentInfo.Show();
            }

            else
            {

                MessageBox.Show("the student ID should be in xxx-xx-xxxx pattern");


            }
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxDepartment.Items.Add("");
            comboBoxDepartment.Items.Add("Information System");
            comboBoxDepartment.Items.Add("International Affairs");
            comboBoxDepartment.Items.Add("Nursing");
            comboBoxDepartment.Items.Add("Pharmacy");
            comboBoxDepartment.Items.Add("Professional Studies");
            comboBoxDepartment.Items.Add("Psycology");
            comboBoxDepartment.Items.Add("Public Administration");
            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.LastName;
            txtStudentID.Text = s.StudentId;
            comboBoxDepartment.Items.Add(s.Department);
            comboBoxDepartment.SelectedValue = s.Department;
            string enroll = s.Enrolltype;
            if (enroll.ToLower().Trim() == "Part Time")
            {
                radioButtonL.IsChecked = true;
            }
            else
            {
                radioButtonF.IsChecked = true;
            }
        }
        public bool IsStudentidOK(string ID)
        {
            bool isvalid = false;
            Regex regex = new Regex(@"^\d{3}-\d{2}-\d{4}$");
            isvalid = regex.IsMatch(ID) ? true : false;
            return isvalid;
        }
        internal void UpdateStudentList()
        {
            s.FirstName = txtFirstName.Text;
            s.LastName = txtLastName.Text;
            s.StudentId = txtStudentID.Text;
            s.Department = comboBoxDepartment.Text;
            string enroll;
            if (radioButtonF.IsChecked == true)
            {
                enroll = "Full Time";
            }
            else
            {
                enroll = "Part Time";
            }
            s.Enrolltype = enroll;
            StudentInfo.persons[index] = s;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            StudentInfo.Show();

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (IsStudentidOK(txtStudentID.Text))
            {
                MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to edit this student?", "Edit Student Registration Confirmation", MessageBoxButton.YesNo);

                if (dialogResult == MessageBoxResult.Yes)
                {
                    UpdateStudentList();
                    this.Close();
                    StudentInfo.Show();

                }
                else if (dialogResult == MessageBoxResult.No)
                    this.Close();
                StudentInfo.Show();
            }

            else
            {

                MessageBox.Show("the student ID should be in xxx-xx-xxxx pattern");


            }

        }
    }
} 
 
