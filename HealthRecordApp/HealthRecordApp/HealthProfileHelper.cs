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
                result= true;
            }

            return result;


        }

		public static bool ValidateLastName(string lastName)
		{

            var result = false;
            if (lastName!=null && !lastName.Equals(""))
               
            
            {
               result=true;
            }


            return result;

        }


        public static bool ValidateGender(string enteredGender, ref Gender patientGender)
        {
            var result = false;
           /* if (patientGender.Equals(Gender.Female))

            {
                result = true;
            }

            if (patientGender.Equals(Gender.Male))
            {
                result = true;
            }*/
        

           if (enteredGender.Equals("Female"))  
            {
                patientGender = Gender.Female;
                return true;
                
            }
            if (enteredGender.Equals("Male"))
            {
                patientGender = Gender.Male;
                return true;
            }
            if (enteredGender.Equals("Unspecified"))
            {
                patientGender = Gender.Unspecified;
                return true;
            }

            return result;
		}

        public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
        {
           /* {
                var result = false;
                int DOB;
                enteredDOB = int.MinValue.ToString();
                if (int.TryParse(enteredDOB, out DOB))

                {
                    result = true;
                    DOB = DateTime.Parse(enteredDOB);
                }



                return result;

            }*/

            
                 DateTime dt;
                 try
                 { 
                     dt = DateTime.Parse(enteredDOB);
                 }
                 catch (Exception e)
                 {
                     return false;
                 }

                 if (dt.CompareTo(DateTime.Today) > 0)
                     return false;

                 patientDOB = dt;
                 return true;
             }

        



        /*DateTime DOB = new DateTime();
        if (DateTime.TryParse(enteredDOB, out DOB))
        {
            patientDOB = DOB;
            return true;
        }
        else
        {
            return false;
        }*/




        public static bool ValidateHeight(string heightInString, ref int patientHeight)
		{

                for (int i = 0; i < heightInString.ToCharArray().Length; i++)
                {
                    if (heightInString.ToCharArray()[i] > '9' || heightInString.ToCharArray()[i] < '0')
                    {
                        return false;
                    }
                }
                int height = Int32.Parse(heightInString);
                if (height <= 0)
                    return false;
                patientHeight = height;
                return true;
            }
        

		public static bool ValidateWeight(string weightInString, ref int patientWeight)
		{
            try { Convert.ToInt32(weightInString); }
            catch (Exception) { return false; }
            int weight = Convert.ToInt32(weightInString);
            if (weight > 0)
            {
                patientWeight = weight;
                return true;
            }
            else
            {
                return false;
            }
        }
	}
}
