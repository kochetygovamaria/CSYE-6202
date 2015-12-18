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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        internal List<Person> persons = new List<Person>();

        public int count = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FMlogin_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.addAdmin("Jackob", "Hager", "a", "a");
            persons.Add(admin);


        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {

            string password = txtPassword.Password;
            string userlogin = txtUsername.Text;
            bool y = false;




            foreach (Person person in persons)
            {

                if (person is Admin)
                {
                    Admin admin = (Admin)person;
                    if (admin.Username == userlogin && admin.Password == password)
                    {
                        StudentInfo frmstInf = new StudentInfo(persons);
                        this.Hide();
                        frmstInf.Show();
                        y = true;
                        break;
                    }
                }
            }
            if (y != true)
            {
                count++;
            }
            if (count == 3)
            {

                MessageBox.Show("3 attemts");
                this.Close();
            }

        }


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.addAdmin("Jackob", "Hager", "a", "a");
            persons.Add(admin);
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string password = txtPassword.Password;
            string userlogin = txtUsername.Text;
            bool y = false;




            foreach (Person person in persons)
            {

                if (person is Admin)
                {
                    Admin admin = (Admin)person;
                    if (admin.Username == userlogin && admin.Password == password)
                    {
                        StudentInfo frmstInf = new StudentInfo(persons);
                        this.Hide();
                        frmstInf.Show();
                        y = true;
                        break;
                    }
                }
            }
            if (y != true)
            {
                count++;
            }
            if (count == 3)
            {

                MessageBox.Show("3 attemts");
                this.Close();
            }

        

    }
    }
}

