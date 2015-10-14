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
        private DateTime dOB;
        private Gender gender;


        public static int count = 0;

        public HealthProfile()
        { }

        public HealthProfile(string firstName, string lastName, Gender gender, DateTime dOB, int patientWeight, int patientHeight)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.patientWeight = patientWeight;
            this.patientHeight = patientHeight;
            this.gender = gender;
            this.dOB = dOB;
            


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
            get { return DOB; }
            set { DOB = value; }

        }
        public int WeightInPounds
        {
            get { return patientWeight; }
            set { patientWeight = value; }
        }
        public int HeightInInches
        {
            get { return  patientHeight; }
    set { patientHeight = value; }

        }

        public int CalculateAge()
		{
            DateTime today = DateTime.Today;
            return today.Year - dOB.Year;
                
		}

        public int CalculateMaxHeartRate()
        {


            return (220 - CalculateAge());

           


        }

		public decimal CalculateBMI()
		{
            
                return (patientWeight * 703) / (patientWeight * patientWeight);
                    
         

		}

		public void DisplayPatientProfile()

		{
            //var healthprofilehelper = new HealthProfileHelper(firstName, lastName, gender, age, height, weight);
            Console.WriteLine("First Name:{0}", FirstName);
            Console.WriteLine("Last Name:{0}", LastName);
            Console.WriteLine("Gender:{0}", gender);
            Console.WriteLine("Height:{0}",HeightInInches);
            Console.WriteLine("Weight:{0}", WeightInPounds);
             Console.WriteLine("Age: {0}", CalculateAge());
            Console.WriteLine("Max heart rate: {0}", CalculateMaxHeartRate());
            Console.WriteLine("BMI: { 0}", CalculateBMI());
        }
 
		#endregion
	}
}
