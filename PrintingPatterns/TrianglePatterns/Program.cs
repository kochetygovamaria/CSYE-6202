using System;

namespace TrianglePatterns
{
    class Program
    {
        const string STAR = "*";
        const string SPACE = " ";
        const int COUNTER = 10;

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
            for (int r = 0; r < COUNTER; r++)
            {
                for (int c = 0; c <= r; c++)

                    Console.Write(STAR);

                Console.WriteLine();

            }
            Console.WriteLine();
        }

        static void DisplayPatternB()
        {
            for (int r = 10; r >=1 ; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(STAR);
                        }

                Console.WriteLine();
            }
            Console.WriteLine();
        }


        static void DisplayPatternC()
        {
            for (int r = COUNTER; r > 0; r--)
            {for (int c = 0; c < r; c++)
                    Console.Write(STAR);
                Console.WriteLine();


            }

        }
        static void DisplayPatternD()
        {

            for (int r = COUNTER; r > 0; r--)
            {
                for (int c = 0; c < r; c++)
                    Console.Write(SPACE);
                for (int c = 0; c < COUNTER - r; c++)
                    Console.Write(STAR);



                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
        
    


