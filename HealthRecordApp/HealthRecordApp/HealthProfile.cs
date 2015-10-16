using System;
using HealthRecordApp;

namespace HealthRecordApp
{

    public enum Gender
    {
        Unspecified,
        Male,
        Female
    }

    public class HealthProfile

    {



        private const int UnknownValue = -1;
        private int patientWeight;
        private int patientHeight;
        private string firstName;
        private string lastName;
        private DateTime dob;
        private Gender gender;



        public HealthProfile()
        { }

        public HealthProfile(string firstName, string lastName, Gender gender, DateTime dob, int patientWeight, int patientHeight)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.patientWeight = patientWeight;
            this.patientHeight = patientHeight;
            this.gender = gender;
            this.dob = dob;
        }
        

        
        public string FirstName

        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #region Methods


        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }

        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        

    }
        public int WeightInPounds
        {
            get { return patientWeight; }
            set { patientWeight = value; }
        }
        public int HeightInInches
        {
            get { return patientHeight; }
            set { patientHeight = value; }

        }

        public int CalculateAge()
        {
            int thisYear = DateTime.Today.Year;
            int age = thisYear - DOB.Year;
            return age;
        

    }

        public int CalculateMaxHeartRate()
        {


            int heartRate = 220 - CalculateAge();
            if (heartRate > 0)
            {
                return heartRate;
            }
            else { return UnknownValue; }

        




    }

        public decimal CalculateBMI()
        {
            decimal bmi = 0;
            bmi=Math.Round((WeightInPounds * 703.00m) / (HeightInInches * HeightInInches), 2);
            return bmi;
           // return Math.Round(bmi, 2);
           // return decimal.Round(((decimal)(patientWeight * 703)) /( (decimal)(patientWeight * patientWeight)), 2);
            


    }

        public void DisplayPatientProfile()

        {
            //var healthprofilehelper = new HealthProfileHelper(firstName, lastName, gender, age, height, weight);

            
            Console.WriteLine("DisPlaying Patient Profile:");
            Console.WriteLine("===========================");
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Gender: " +Gender.ToString());
            Console.WriteLine("Date of Birth: " +DOB.ToString());
            Console.WriteLine("Height:" +HeightInInches+ "inches");
            Console.WriteLine("Weight:" +WeightInPounds + "pounds");
            Console.WriteLine("Age:" +CalculateAge());
            Console.WriteLine("Max heart rate:" +CalculateMaxHeartRate());
            Console.WriteLine("BMI:" +CalculateBMI());
        }
           


		#endregion
	}
    
}
