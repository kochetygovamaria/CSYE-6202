using System;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

		static void Main(string[] args)
		{

            Console.WriteLine("Please enter the type");
            String userInput = Console.ReadLine();

            bool check = UserEnteredSentinelValue(userInput);
            check = UserEnteredValidGasType(userInput);
            Console.WriteLine("Please entre the amount");
           userInput = Console.ReadLine();

           /* int amount = 0;
            Console.WriteLine("");
            amount = Console.Read();
            double totalCost = 0;
            CalculateTotalCost(GasType.RegularGas, amount, totalCost);*/


        }

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;
            if (userInput.ToLower() =="q")
            {
                result = true;
            }


			return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;

            if (userInput.ToLower() == "r" || userInput.ToLower()== "m" || userInput.ToLower()== "p" || userInput.ToLower()=="d")
                result = true;
			
			
			return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
            string value;
            double number;
			var result = false;

            value = Double.PositiveInfinity.ToString();
            if (Double.TryParse(value, out number))
                Console.WriteLine(number);

            result = true;

			

			return result;
		}

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
			GasType gasType = GasType.None;
            


            return gasType;
		}

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;

			// your implementation here

			return result;
	}

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            
                
            }

		}
	}

