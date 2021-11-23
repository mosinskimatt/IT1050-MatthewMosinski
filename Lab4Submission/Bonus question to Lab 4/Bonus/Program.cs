using System;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an application that displays the following patterns separately, one below the other.
            //Use for loops to generate the patterns. All asterisks (*) should be displayed by a single statement of the form Console.Write( '*' );
            //which causes the asterisks to display side by side. A statement of the form Console.WriteLine(); can be used to move to the next line.
            //A statement of the form Console.Write( ' ' ); can be used to display a space for the last two patterns.
            //There should be no other output statements in the application.
            //[Hint: The last two patterns require that each line begin with an appropriate number of blank spaces.]  
   

            Console.WriteLine("***Bonus Question***\n");
            Console.WriteLine("(a)\n");

            for (int j = 1; j < 10; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("\n(b)\n");
            for (int j = 1; j <= 10; j++)
            {
                for (int k = j; k <= 10; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("\n(c)\n");
            for (int j = 10; j >= 1; j--)
            {
                for (int l = 0; l <= 10 - j; l++)
                {
                    Console.Write(" ");
                }
                for (int k = j; k >= 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n(d)\n");
            for (int j = 10; j >= 1; j--)
            {
                for (int l = 10; l >= 10 - j; l--)
                {
                    Console.Write(" ");
                }
                for (int k = j; k <= 10; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
