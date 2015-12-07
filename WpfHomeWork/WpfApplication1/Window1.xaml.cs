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
    public partial class Window1 : Window
    {
        internal List<Person> persons;
        internal Window1(List<Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
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
                            Student s = null;
                            foreach (Person person in persons)
                            {
                                if (person is Student)
                                {
                                    s = (Student)person;
                                    if (s.StudentId == row.StudentId)
                                    {
                                        index = persons.IndexOf(person);
                                        break;
                                    }
                                }
                            }
                            RemoveStudentForm red = new RemoveStudentForm(s, index);
                            red.Window1 = this;
                            this.Hide();
                            red.Show();
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

    
    private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxDepartment.Items.Add("");
            comboBoxDepartment.Items.Add("Information Systems");
            comboBoxDepartment.Items.Add("International Affairs");
            comboBoxDepartment.Items.Add("Nursing");
            comboBoxDepartment.Items.Add("Pharmacy");
            comboBoxDepartment.Items.Add("Professional Studies");
            comboBoxDepartment.Items.Add("Psychology");
            comboBoxDepartment.Items.Add("Public Aministration");
            for (int i = 0; i < 10; i++)
            {
                ADDARRAY(i);
            }
            intialiazeGridView();
        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
                            comboBoxDepartment = row.Department;
                            string enroll = row.Enrolltype;
                            if (enroll == "Part Time")
                            {
                                radioButton.IsChecked = true;

                            }
                            else
                            {
                                radioButton1.IsChecked = true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void buttonNewStudent_Click(object sender, RoutedEventArgs e)
        {
            NewStudentRegistration newstudent = new NewStudentRegistration();
            newstudent.Window1 = this;
            this.Hide();
            newstudent.Show();
        }

        private void buttonEditStudent_Click(object sender, RoutedEventArgs e)
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
                            Student s = null;
                            foreach (Person person in persons)
                            {
                                if (person is Student)
                                {
                                    s = (Student)person;
                                    if (s.StudentId == row.StudentId)
                                    {
                                        index = persons.IndexOf(person);
                                        break;
                                    }
                                }
                            }
                            EditStudentForm ed = new EditStudentForm(s, index);
                            ed.Window1 = this;
                            this.Hide();
                            ed.Show();
                        } } } }
            catch (Exception )
            {

            }
        }
                            



    
    
   
    public void intialiazeGridView() { 
        List<Student> st = new List<Student>();
       foreach(Person person in persons)
        {
        if (person is  Student)
        {
        st.Add((Student)person);
        }
}
      dataGrid.ItemSource=st;

    }
    public void ADDARRAY( int i)
    {
        Student s = new Student();
        bool f = true;
        while (f)
        {
            System.Threading.Thread.Sleep(100);
            try
            {
                s = NewStudent.GenerateStudentRandomly(i);
                f = false;

            }
            catch(Exception e)
            {
                f = true;
            }

        }
        persons.Add(s);
    }

    }
}

