using System;

namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string seriesType = "";

            Console.WriteLine("Enter an integer value between 1 and 100:");

            try
            {
                input = int.Parse(Console.ReadLine());
                if (input < 1 || input > 100)
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter an integer value between 1 and 100.");
                return;
            }

            Console.WriteLine("Choose a series of integer numbers: (Odd/Even)");

            try
            {
                seriesType = Console.ReadLine();
                if (seriesType.ToLower() != "odd" && seriesType.ToLower() != "even")
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Please choose either 'Odd' or 'Even'.");
                return;
            }

            Console.WriteLine($"You have selected the {seriesType} series. The numbers between 0 and {input} are:");

            if (seriesType.ToLower() == "odd")
            {
                for (int i = 1; i <= input; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 0; i <= input; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}