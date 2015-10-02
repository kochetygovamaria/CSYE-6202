using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
            FizzBuzz fizzBuzz = new FizzBuzz();
            Console.Out.WriteLine(fizzBuzz.RunFizzBuzz(0));
            Console.In.ReadLine();
		}
	}
}
