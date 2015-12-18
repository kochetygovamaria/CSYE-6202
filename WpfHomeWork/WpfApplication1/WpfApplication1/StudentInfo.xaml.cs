using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
   // List<Person> persons;
    public partial class StudentInfo : Window
    {
        
        internal StudentInfo(List<Person> persons)

        {
            InitializeComponent();
            this.persons = persons;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        internal List<Person> persons;
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxDepartment.Items.Add("");
            comboBoxDepartment.Items.Add("Information Systems");
            comboBoxDepartment.Items.Add("International Affairs");
            comboBoxDepartment.Items.Add("Nursing");
            comboBoxDepartment.Items.Add("Pharmacy");
            comboBoxDepartment.Items.Add("Professional Studies");
            comboBoxDepartment.Items.Add("Psychology");
            comboBoxDepartment.Items.Add("Public Aministration");
            for (int i = 0; i < 10; i++)
            {
                ADDTEMOPORRAYSTUDENT(i);
            }
            initializeGreedView();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            {
                try
                {
                    if (dataGrid.SelectedItem != null)
                    {
                        if (dataGrid.SelectedItem is Student)
                        {
                            var row = (Student)dataGrid.SelectedItem;

                            if (row != null)
                            {

                                txtStudentId.Text = row.StudentId;
                                txtFirstName.Text = row.FirstName;
                                txtLastName.Text = row.LastName;
                                comboBoxDepartment.Text = row.Department;
                                string enrollType = row.Enrolltype;
                                if (enrollType == "Part Time")
                                {
                                    radbPartTime.IsChecked = true;
                                }
                                else
                                {
                                    radbFullTime.IsChecked = true;


                                }

                            }
                        }
                    }
                }
                catch (Exception)
                {
                }

            }
        }

        public void initializeGreedView()
        {

            List<Student> temp = new List<Student>();
            foreach (Person person in persons)
            {
                if (person is Student)
                {
                    temp.Add((Student)person);
                }
            }
            dataGrid.ItemsSource = temp;
        }

        public void ADDTEMOPORRAYSTUDENT(int i)
        {
            Student st = new Student();
            bool flag = true;
            while (flag)
            {
                System.Threading.Thread.Sleep(50);
                try
                {
                    st = HelperClass.CreateRandom(i);
                    flag = false;
                }
                catch (Exception e)
                {
                    flag = true;
                }
            }

            persons.Add(st);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NewStudentRegistration nw = new NewStudentRegistration();
            nw.StudentInfo = this;
            this.Hide();
            nw.ShowDialog();


        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (dataGrid.SelectedItem != null)
                {
                    if (dataGrid.SelectedItem is Student)
                    {
                        var row = (Student)dataGrid.SelectedItem;

                        if (row != null)
                        {

                            int index = 0;
                            Student st = null;

                            foreach (Person person in persons)
                            {

                                if (person is Student)
                                {
                                    st = (Student)person;
                                    if (st.StudentId == row.StudentId)
                                    {
                                        index = persons.IndexOf(person);
                                        break;
                                    }
                                }
                            }


                            EditStudentForm frmAddst = new EditStudentForm(st, index);
                            frmAddst.StudentInfo = this;
                            this.Hide();
                            frmAddst.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (dataGrid.SelectedItem != null)
                {
                    if (dataGrid.SelectedItem is Student)
                    {
                        var row = (Student)dataGrid.SelectedItem;

                        if (row != null)
                        {

                            int index = 0;
                            Student st = null;

                            foreach (Person person in persons)
                            {

                                if (person is Student)
                                {
                                    st = (Student)person;
                                    if (st.StudentId == row.StudentId)
                                    {
                                        index = persons.IndexOf(person);
                                        break;
                                    }
                                }
                            }


                            RemoveStudentForm frmAddst = new RemoveStudentForm(st, index);
                            frmAddst.StudentInfo = this;
                            this.Hide();
                            frmAddst.Show();

                        }
                    }
                }
            }
            catch (Exception)
            {
            }


        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
        }
    }
}
