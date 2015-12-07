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
    /// Interaction logic for RemoveStudentForm.xaml
    /// </summary>
    public partial class RemoveStudentForm : Window
    {
        internal Window1 Window1;
        Student s;
        int index = 0;
        internal RemoveStudentForm(Student student, int index)
        {
            this.s = student;
            this.index = index;
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBoxResult.Show("Are you sure you would like to delete information");
            if(dialogResult==MessageBoxResult.Yes)
            {
                Window1.persons.Remove(index);
                this.Close();
                Window1.initializeGridView();
                Window1.Show();

            }

        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            IDtxt.Text = s.StudentId;
            LastnameTXT.Text = s.LastName;
            FirstNameTXT.Text = s.FirstName;
            comboBoxDepartment.Items.Add(s.Department);
            comboBoxDepartment.SelectedIndex = 0;
            string enroll = s.Enrolltype;
            if (enroll=="Part Time")
            {
                radioButtonF.IsChecked = true;
            }
            else
            {
                radioButton1.IsChecked = true;
            }

        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window1.initializeGridView();
            Window1.Show();
        }
    }
}
