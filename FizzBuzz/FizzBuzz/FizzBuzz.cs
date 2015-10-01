namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int number)
		{
			string result = number.ToString();

            if (number == 0)
                result = number.ToString();

            if (number == 1)
                result = number.ToString();

            if (number % 3 == 0)

                result = "Fizz";

            if (number % 5 == 0)
            
                result = "Buzz";
           
            if (number % 15 == 0)

                result = "FizzBuzz";

            return result;
		}
	}
}
