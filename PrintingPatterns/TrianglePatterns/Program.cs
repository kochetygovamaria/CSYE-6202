using System;

namespace TrianglePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPatternA();
            DisplayPatternB();
            DisplayPatternC();
            DisplayPatternD();

            Console.ReadLine();
        }

        static void DisplayPatternA()
        {
            for (int i = 1; i <= 11; i++)
            {
                for (int j = 1; j <= 1 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }

        static void DisplayPatternB()
        {
            for (int i = 10; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }

        static void DisplayPatternC()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i < j)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void DisplayPatternD()
        {

            for (int i = 10; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i > j)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
                Console.ReadLine();

            }
        }
    }
}

