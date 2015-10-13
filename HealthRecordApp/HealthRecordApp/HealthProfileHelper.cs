using System;
using System.Text.RegularExpressions;

namespace HealthRecordApp
{ 
	public class HealthProfileHelper
	{
        public static bool ValidateFirstName(string firstName)
        {
            if (Regex.Match(firstName, "^[A-Z][a-zA-Z]*$").Success)

            {
                return true;
            }

                    return false;
                
            
        }

		public static bool ValidateLastName(string lastName)
		{
            if (!Regex.Match(lastName, "^[A-Z][a-zA-Z]*$").Success)
            {
                return true;
            }


                return false;
            
		}

		public static bool ValidateGender(string enteredGender, ref Gender patientGender)
		{
            if (enteredGender == 'f')
                Gender = "Female";
            else if (enteredGender == 'F')
                Gender = "Female";
            else if (enteredGender == 'm')
                Gender = "Male";
            else if (enteredGender == 'M')
                Gender = "Male";
            else
                Gender = "Unspecified";

            return false;
		}

		public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
		{
              if ( enteredDOB <1920 && enteredDOB>2015)


			return false;
		}

		public static bool ValidateHeight(string heightInString, ref int patientHeight)
		{
			return false;
		}

		public static bool ValidateWeight(string weightInString, ref int patientWeight)
		{
			return false;
		}
	}
}
