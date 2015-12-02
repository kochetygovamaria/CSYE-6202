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
    public partial class FMlogin : Form
    {
        public FMlogin()
        {
            InitializeComponent();

        }
        List<Person> persons= new List<Person>();
        int count = 3;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FMlogin_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.addAdmin("Jackob", "Hager", "Jakob", "Jakob");
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
           
            string user = txtUserName.Text;
            string password = textPassword.Text;
            bool y = false;
            
           
 
            foreach(Person person in persons)
            {
                    if (person is Admin)
                    {
                        Admin ad = (Admin)person;
                        if (ad.UserName == user && ad.Password == password)

                        {

                            FMstudentInfo fmst = new FMstudentInfo(persons);
                            fmst.Show();
                            this.Hide();
                            y = true;
                            break;


                        }
                        if (y!=true)
                        {
                            count--;
                        }
                    if (count == 0)
                    {
                        MessageBox.Show("Used 3 attemps", "enter your info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        this.Close();
                    }

                }
            }
                

        }
    }
}
