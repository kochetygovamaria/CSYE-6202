using System;
using System.Text.RegularExpressions;

namespace HealthRecordApp
{ 
	public class HealthProfileHelper


	{
        public static bool ValidateFirstName(string firstName)
        {
            var result = false;
            if (firstName!=null && !firstName.Equals(""))

            {
                result=true;
            }

                    return result;
                
            
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
            var result = false;
          /*  if (patientGender.Equals(Gender.Female))

            {
                result = true;
            }

            if (patientGender.Equals(Gender.Male))
            { result = true;
            }*/

            if (enteredGender.ToLower().Equals("f"))  
            {
                patientGender = Gender.Female;
                return true;
                
            }
            if (enteredGender.ToLower().Equals("m"))
            {
                patientGender = Gender.Male;
                return true;
            }

            return result;
		}

		public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
		{
            var result = false;
            int DOB;
           
           // if (int.TryParse(enteredDOB, out DOB))
           
            {
                result = true;
                patientDOB = DateTime.Parse(DOB);
            }
            

            
                return result;
            
		}

		public static bool ValidateHeight(string heightInString, ref int patientHeight)
		{
            int height = int.Parse(heightInString);
            
            if(height>0 )
            {
                patientHeight = height;
                return true;
            }
            
			return false;
		}

		public static bool ValidateWeight(string weightInString, ref int patientWeight)
		{
            int weight = int.Parse(weightInString);
            if (weight > 0)
            {
                patientWeight = weight;
                return true;
            }
			return false;
		}
	}
}
