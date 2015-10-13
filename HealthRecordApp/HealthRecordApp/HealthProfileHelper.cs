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
			return false;
		}

		public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
		{

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
