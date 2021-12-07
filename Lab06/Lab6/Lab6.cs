using System;

namespace Lab6
{
    class Lab6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab06");
            Console.WriteLine("Matthew Mosinski", "12/4/21");
            Console.WriteLine("\nQuestion 2:\n");

            string[] months = new string[]{"January", "February", "March",
            "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            Console.WriteLine($"{"Index"} {"Month",10}");

            for (int counter = 0; counter < months.Length; counter++)
            {
                Console.WriteLine($"{counter}{months[counter],15}");
            }

            Console.WriteLine("\nQuestion3:\n");
            string[] seasons = new string[] { "Spring", "Summer", "Autumn", "Winter" };

            foreach (string season in seasons)
                Console.WriteLine(season);

            Console.WriteLine("\nQuestion 4:\n");
            int[] elements = new int[1000];

            Random random = new Random();

            // Popluate the array with random numbers
            for (int counter = 0; counter < elements.Length; counter++)
            {
                int randomNumber;
                randomNumber = random.Next(0, 100);
                elements[counter] = randomNumber;
            }

            // Iterate over array and print random numbers
            foreach (int num in elements)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\nQuestion5\n");
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 1;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }

            Console.WriteLine("\nQuestion 6:\n");
            string[] name = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int j = 0;

            while (j < name.Length)
            {
                Console.WriteLine("{0,2}. {1}", j, name[j]);
                j++;
            }

            Console.WriteLine("\nQuestion 7:\n");
            string[] streetNames = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int k = 1;
            foreach (string x in streetNames)
            {
                Console.WriteLine("{0}. {1}", k, x);
                k++;
            }
        }
    }
}
