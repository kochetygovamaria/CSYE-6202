using System;

namespace HealthRecordApp
{
    class Program
    {
        static HealthProfile hp = new HealthProfile();

        static void Main(string[] args)
        {
            Boolean q = false;

            Console.WriteLine("Please enter the firstName");
            while (!q)
            {
                String firstName = Console.ReadLine();
                bool check = HealthProfileHelper.ValidateFirstName(firstName);

                if (check == false)
                {
                    
                        q = true;
                        break;
                      

                }
                else
                {
                    hp.FirstName = firstName;
                    Console.WriteLine("Please enter your LastName");
                }

                String lastName = Console.ReadLine();
                check = HealthProfileHelper.ValidateLastName(lastName);
                {
                    if (check == false)
                    {
                        q = true;
                        break;
                    }

                    else
                    {
                        hp.LastName = lastName;
                        Console.WriteLine("Please enter the Gender");
                    }
                    String enteredGender = Console.ReadLine();
                    Gender gd = new Gender();
                    check = HealthProfileHelper.ValidateGender(enteredGender, ref gd);
                    if (check == false)
                    {
                        q = true;
                        break;

                    }
                    else
                    {
                        hp.Gender = gd;
                        Console.WriteLine("Enter the DOB");

                    }


                    String enteredDOB = Console.ReadLine();
                    DateTime dt = new DateTime();
                    check = HealthProfileHelper.ValidateDateOfBirth(enteredDOB, ref dt);

                    if (check == false)
                    {
                        q = true;
                        break;

                    }
                    else
                    {
                        DateTime patientDOB = DateTime.Today;

                        

                        
                        hp.DOB = dt;
                        Console.WriteLine("Please height");
                    }




                    
                    String heightInString = Console.ReadLine();
                    int pHeight = 0;
                    check = HealthProfileHelper.ValidateHeight(heightInString, ref pHeight);
                    if (check == false)
                    {
                        q = true;
                        break;

                    }
                    else
                    {
                        int patientHeight = int.Parse(heightInString);
                        hp.HeightInInches = pHeight;
                        Console.WriteLine("Please Enter weight");
                    }
                    String weightInString = Console.ReadLine();
                    int pweight = 0;
                    check = HealthProfileHelper.ValidateWeight(weightInString, ref pweight);
                    if (check == false)
                    {
                        q = true;
                        break;
                    }
                    else
                    {
                        int patientWeight = int.Parse(weightInString);
                        hp.WeightInPounds = pweight;

                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    hp.DisplayPatientProfile();
                    Console.ReadLine();
                }
            }
        }
    }
}

    