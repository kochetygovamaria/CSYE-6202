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
            Boolean q = false;


            Console.WriteLine("Please enter the gas type");
            while (!q)
            {
                String gasType = Console.ReadLine();


                bool check = UserEnteredSentinelValue(gasType);
                if (check == true)
                {
                    q = true;
                    break;
                }
                else
                {

                    check = UserEnteredValidGasType(gasType);
                    if (check == false)
                    {
                        q = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please entre the amount");
                    }

                    String userInput = Console.ReadLine();
                    
                   
                    check = UserEnteredValidAmount(userInput);
                    if (check == false)
                    {
                        q = true;
                        break;
                    }
                    else
                    {
                        char c = Convert.ToChar(gasType);
                        GasType i= GasTypeMapper(c);

                        double totalCost = 0;
                        int z = Convert.ToInt32(userInput);
                        Console.Write("You purchase :    "  +   z  +  i);
                        Console.ReadLine();





                        CalculateTotalCost(i, z, ref totalCost);
                        Console.Write("You total cost: " +  totalCost);
                }
            }
        }
    }

   

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
        {

            var result = false;
            if (userInput == null)

                return result;


            
            if (userInput.ToLower().Equals("q"))
            
                result = true;
            


            return result;
        }


        // use this method to parse and check the characters entered
        // this does not conform 
        public static bool UserEnteredValidGasType(string userInput)
        { 
        var result = false;
            
            if (userInput == null)

                return result;

            
            if (userInput.ToLower().Equals("r") || userInput.ToLower().Equals( "m") || 
                userInput.ToLower().Equals("p") ||
                userInput.ToLower().Equals("d")||
               userInput.Equals("R") || userInput.Equals("M") || userInput.Equals("P") ||
              userInput.Equals("D"))
            
           
                
                    result = true;
            
             
            
                
            
			return result;
		}

// use this method to parse and check the double type entered
// please use Double.TryParse() method 
public static bool UserEnteredValidAmount(string userInput)
        {
            var result = false;
            if (userInput == " ")
                return false;

            double gasAmount;

            if (Double.TryParse(userInput, out gasAmount))
                if (gasAmount <= 9 && gasAmount >= 0)
                    result =true;
                else
                {
                    result = true;
                }       

          return result;
    }

    // use this method to map a valid char entry to its enum representation
    // e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
    // this mapping "must" be used within CalculateTotalCost() method later on
    public static GasType GasTypeMapper(char c)
        {



            GasType gasType = GasType.None;

            

                switch (c)
                {
                    case 'r':
                        gasType = GasType.RegularGas;

                        break;

                    case 'R':
                        gasType = GasType.RegularGas;

                        break;

                    case 'M':
                        gasType = GasType.MidgradeGas;

                        break;

                    case 'm':
                        gasType = GasType.MidgradeGas;

                        break;
                    case 'p':
                        gasType = GasType.PremiumGas;

                        break;
                    case 'P':
                        gasType = GasType.PremiumGas;

                        break;

                    case 'd':
                        gasType = GasType.DieselFuel;

                        break;

                    case 'D':
                        gasType = GasType.DieselFuel;

                        break;


                }
                return gasType;
            }
        
        

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;
            switch (gasType)
            {
                case GasType.RegularGas:
                    result = 1.94;
                    break;
                case GasType.MidgradeGas:
                    result = 2.0;
                    break;
                case GasType.PremiumGas:
                    result = 2.24;
                    break;
                case GasType.DieselFuel:
                    result = 2.17;
                    break;
            }
                    return result;
            }
	

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            
            totalCost = gasAmount * GasPriceMapper(gasType);
                
            }

		}
	}

