using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matthew Mosinski Lab4\n");
            Console.WriteLine("Question 4:\n");

            for (int i = 1; i <= 100; ++i)
            {
                if ((i % 2) == 0)  // it’s even
                    Console.WriteLine($"{i} Even");
                else
                    Console.WriteLine($"{i} Odd"); //it's odd
            }
            Console.WriteLine("\n");

            Console.WriteLine("Question 5:\n");

            Console.Write("Please enter a temperature: ");

            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 10)
                Console.WriteLine("Polar Bear");
            else if (temp < 20)
                Console.WriteLine("Penguin");
            else if (temp < 40)
                Console.WriteLine("Moose");
            else if (temp < 50)
                Console.WriteLine("Reindeer");
            else if (temp < 60)
                Console.WriteLine("Deer");
            else if (temp < 70)
                Console.WriteLine("Turle");
            else if (temp < 80)
                Console.WriteLine("Lion");
            else if (temp < 90)
                Console.WriteLine("Fish");
            else
                Console.WriteLine("Bug");

            Console.WriteLine("\n");

            Console.WriteLine("Question 6:\n");

            Console.Write("Please enter the exhibit number(1 thru 9): ");
            string str = Console.ReadLine();
            int caseSwitch = int.Parse(str);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Polar Bear");
                    break;
                case 2:
                    Console.WriteLine("Penquin");
                    break;
                case 3:
                    Console.WriteLine("Moose");
                    break;
                case 4:
                    Console.WriteLine("Reindeer");
                    break;
                case 5:
                    Console.WriteLine("Deer");
                    break;
                case 6:
                    Console.WriteLine("Turtle");
                    break;
                case 7:
                    Console.Write("Lion");
                    break;
                case 8:
                    Console.WriteLine("Fish");
                    break;
                case 9:
                    Console.WriteLine("Bug");
                    break;
            }
            Console.WriteLine("\n)");

            Console.WriteLine("Question 7:");
            Console.WriteLine("The errors in the provided code are corrected and corrected code ouputs the following:");

            int m = 10;
            while (m < 21)
            {
                Console.WriteLine($"{m}");
                ++m;
            }

            Console.WriteLine("Question 8:");
            Console.WriteLine("The errors in the provided code are corrected and the corrected code ouputs the following:");

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine($"{i}\n********");
            }
        }
    }
}
