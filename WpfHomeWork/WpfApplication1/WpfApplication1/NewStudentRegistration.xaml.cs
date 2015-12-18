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
    /// Interaction logic for NewStudentRegistration.xaml
    /// </summary>
    public partial class NewStudentRegistration : Window
    {
        internal StudentInfo StudentInfo;
        public NewStudentRegistration()
        {
            InitializeComponent();
        }
        private void Grid_Loaded(object sender,RoutedEventArgs e)
        {
            comboBoxDepartment.Items.Add("");
            comboBoxDepartment.Items.Add("Information System");
            comboBoxDepartment.Items.Add("International Affairs");
            comboBoxDepartment.Items.Add("Nursing");
            comboBoxDepartment.Items.Add("Pharmacy");
            comboBoxDepartment.Items.Add("Professional Studies");
            comboBoxDepartment.Items.Add("Psycology");
            comboBoxDepartment.Items.Add("Public Administration");
            buttonAdd.IsEnabled = false;
            buttonResert.IsEnabled = false;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (isStudentIDOk(txtStudentID.Text))
            {
                if(txtFirstName.Text.Trim()  !="" && txtLastName.Text.Trim() !="" && comboBoxDepartment.SelectedIndex>0 )
                {
                    string enroll;
                    if (radioButtonF.IsChecked==true)
                    {
                        enroll = "Full Time";


                    }
                    else
                    {
                        enroll = "Part Time";
                    }
                    Student s = new Student();
                    s.addStudent(txtFirstName.Text, txtLastName.Text, txtStudentID.Text, comboBoxDepartment.SelectedItem.ToString(), enroll);
                    StudentInfo.persons.Add(s);
                    this.Hide();
                    StudentInfo.initializeGreedView();
                    StudentInfo.Show();
                      
                }
                else
                {
                    MessageBox.Show("Please, Fill out the form");
                }

            }
            else
            {
                MessageBox.Show("Please enter valid ID");
            }

        }
        public bool isStudentIDOk(string ID)
        {
            bool isvalid = false;
            Regex regex = new Regex(@"^\d{3}-\d{2}-\d{4}$");
            isvalid = regex.IsMatch(ID) ? true : false;
            return isvalid;
        }

        private void buttonResert_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text="";
           txtLastName.Text="";
             txtStudentID.Text="";
            comboBoxDepartment.SelectedIndex=0;
            radioButtonF.IsChecked = true;
            buttonResert.IsEnabled = false;
            buttonAdd.IsEnabled = false;
            buttonAdd.IsEnabled = true;
            buttonResert.IsEnabled = true;


        }
        private void EnableResetButton(object sender, RoutedEventArgs e)
        {
            buttonResert.IsEnabled = true;
            int x = comboBoxDepartment.SelectedIndex;
            if(txtFirstName.Text.Trim()!=""&& txtLastName.Text.Trim()!=""&& comboBoxDepartment.SelectedIndex!=-1)
            {
                buttonAdd.IsEnabled = true;

            }

            }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (isStudentIDOk(txtStudentID.Text))
            {
                if (txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" && comboBoxDepartment.SelectedIndex > 0)
                {
                    string enroll;
                    if (radioButtonF.IsChecked == true)
                    {
                        enroll = "Full Time";


                    }
                    else
                    {
                        enroll = "Part Time";
                    }
                    Student s = new Student();
                    s.addStudent(txtFirstName.Text, txtLastName.Text, txtStudentID.Text, comboBoxDepartment.SelectedItem.ToString(), enroll);
                    StudentInfo.persons.Add(s);
                    this.Hide();
                    StudentInfo.initializeGreedView();
                    StudentInfo.Show();

                }
                else
                {
                    MessageBox.Show("Please, Fill out the form");
                }

            }
            else
            {
                MessageBox.Show("Please enter valid ID");
            }

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = "";
            comboBoxDepartment.SelectedIndex = 0;
            radioButtonF.IsChecked = true;
            buttonResert.IsEnabled = false;
            buttonAdd.IsEnabled = false;
            buttonAdd.IsEnabled = true;
            buttonResert.IsEnabled = true;
        }
    }

    }

