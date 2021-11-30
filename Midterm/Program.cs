using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Midterm\nMatthew Mosinski\t11-28-21\n");

            Console.WriteLine("Question 2");
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine(keepLooping);
                keepLooping = true;
            }

            Console.WriteLine("Question 3\n");

            int counter = 1;
            while (counter <= 7)
            {
                Console.WriteLine("[{0}]", Math.Pow(2, counter));
                counter++;
            }

            Console.WriteLine("Question 4\n");

            for (int i = 49; i >= 1; i--)
            {
                if (i > 1)
                    Console.Write("{0},", i);
                else
                    Console.Write("{0}", i);
            }

            Console.WriteLine("Question 5\n");

            for (int i = 1; i <= 21; i++)
            {
                if ((i % 2) != 0)
                    Console.Write("{0} ", i);
            }


            Console.WriteLine("Extra Credit");

            int j = 6;
            for(int i = j - 1; i >= 1; i--)
            {
                for(int m = 1; m <= i; m++)
                {
                    Console.Write("{0}", m);
                }
                Console.Write(" ");
                for(int n = i - 1; n >= 1; n--)
                {
                    Console.Write("{0}", n);
                }

                Console.WriteLine();
            }
        }
    }
}