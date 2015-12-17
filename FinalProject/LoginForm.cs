using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        List<Person> persons = new List<Person>();
        List<Appoiment> appoimnet = new List<Appoiment>();
        List<Doctor> doctor = new List<Doctor>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.addAdmin("John", "Brown", "ad", "ad", "admin");

            persons.Add(admin);

            HospitalAdminPerson hadmin = new HospitalAdminPerson();
            hadmin.addHospitalAdminPerson("Jakob", "Hager", "a", "a", "hadmin");
            persons.Add(hadmin);



        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string password = textPassword.Text;

            foreach (Person person in persons)
            {
                if (person is Admin)
                {
                    Admin ad = (Admin)person;
                    if (ad.UserName == user && ad.Password == password)

                    {
                        MainForm fmst = new MainForm(persons, appoimnet, doctor);


                        if (ad.AccessPoint == "admin")
                        {
                            fmst.Show();
                            // ftest.Show();
                            this.Hide();
                            // y = true;
                            // break;


                        }
                    }
                }
                        else if (person is HospitalAdminPerson)
                        {
                            HospitalAdminPerson hadmin = (HospitalAdminPerson)person;
                            if (hadmin.UserName == user && hadmin.Password == password)
                            {
                                HospitalAdmin hadm = new HospitalAdmin(persons, doctor);
                                if (hadmin.AccessPoint == "hadmin")
                                {
                                    hadm.Show();
                                    this.Hide();
                                  //  y = true;
                                   // break;

                                }


                            /*    if (y != true)
                                {
                                    count--;
                                }
                                if (count == 0)
                                {
                                    MessageBox.Show("Used 3 attemps", "enter your info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    this.Close();

                                }*/
                            }
                        

                    }
                }
            }
        }
    }







