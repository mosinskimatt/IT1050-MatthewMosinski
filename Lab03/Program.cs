using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 2: Declare 2 in variables - speed & speedLimit
            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("QUESTION 2:");
                Console.WriteLine("SLOW NOW\n");
            }

            // Question 3: If-Else statement
            bool isTrue;

            isTrue = true; //false alternative to true

            Console.WriteLine("QUESTION 3:");
            if (isTrue)
            {
                Console.WriteLine("It is true!\n");
            }
            else
            {
                Console.WriteLine("It is false!\n");
            }

            //Question 4: Farenheit conversion
            Console.WriteLine("QUESTION 4:");
            Console.Write("please enter the temperature in farenheit: ");

            double fahrenheit = Convert.ToDouble(Console.ReadLine()); //code to read value from user and convert to double
            double celsius = (fahrenheit - 32d) * 5d / 9d; //code to convert to celcius

            Console.WriteLine("The temperature you entered converted to Celsius is: {0}", celsius);
        
            if (fahrenheit < 40) 
            {
                Console.WriteLine("It is cold\n");
            }
            else
            {
                Console.WriteLine("it is hot\n");
            }

            //Question 5: Write a while loop that outputs values 1-10. Increment by 1
            Console.WriteLine("QUESTION 5:");

            int m = 1;
            while (m <= 10)
            {
                Console.WriteLine(m);
                m++;
            }
                Console.WriteLine();
            

            //Question 6: Write a while loop that outputs values 60 to 20. Decrment by 1 (increment by 1)
            Console.WriteLine("QUESTION 6:");

            int d = 60;
            while (d >= 20)
            {
                Console.WriteLine(d);
                d--;
            }

            Console.WriteLine();
            

            //Question 7: Create a while that outputs values 10-20.
            Console.WriteLine("QUESTION 7:");

            int a = 10;
            while (a <= 20)
            {
                Console.WriteLine(a);
                a++;
            }
        }

    }
}
