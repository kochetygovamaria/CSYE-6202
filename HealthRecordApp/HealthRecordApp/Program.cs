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
                        break;
                    }

                    else
                    {
                        hp.LastName = lastName;
                        Console.WriteLine("Please entter the Date Of Birth");
                    }

                    String enteredDOB = Console.ReadLine();
                    DateTime dt = new DateTime();
                    check = HealthProfileHelper.ValidateDateOfBirth(enteredDOB, ref dt);

                    if (check == false)
                    {
                        break;

                    }
                    else
                    {
                        int DOB = int.Parse(enteredDOB);
                        hp.DOB = dt;
                        Console.WriteLine("Please enter the Gender");
                    }

                    String enteredGender = Console.ReadLine();
                    Gender gd = new Gender();
                    check = HealthProfileHelper.ValidateGender(enteredGender, ref gd);
                    if (check == false)
                    {
                        break;

                    }
                    else
                    {
                        hp.Gender = gd;
                        Console.WriteLine("Enter the height");

                    }
                    String heightInString = Console.ReadLine();
                    int pHeight = 0;
                    check = HealthProfileHelper.ValidateHeight(heightInString, ref pHeight);
                    if (check == false)
                    {
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
                    if (check==false)
                    {
                        break;
                    }
                    else
                    {
                        int patientWeight = int.Parse(weightInString);
                        hp.WeightInPounds = pweight;
                        hp.DisplayPatientProfile();
                    }
            }
            }
        }
    }
}
    