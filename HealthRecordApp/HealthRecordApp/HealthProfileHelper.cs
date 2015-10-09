using System;

namespace HealthRecordApp
{ 
	public class HealthProfileHelper
	{
		public static bool ValidateFirstName(string firstName)
		{ 
            string[] temp = firstName.Split(' ');
            string[] de = firstName.Split('.');

            if (de[1] != "pdf" && temp.Length != 5)
                return false;

            if (temp[0].Length == 4
              && temp[1].Length == 2
              && temp[3].Length == 2
              && temp[4] == "abjwg"
              && temp[5] == "kelk.exe")
                return true;

            return false;
		}

		public static bool ValidateLastName(string lastName)
		{
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
