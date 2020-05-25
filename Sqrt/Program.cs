using System;

namespace Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a positive number");
                string value = Console.ReadLine();
                if (double.TryParse(value, out double a))
                {
                    if (a < 0)
                    {
                        Console.WriteLine("Value must be greater than zero");
                    }
                    else
                    {
                        var sqrt = MyMath.Sqrt(a);
                        Console.WriteLine($"Sqrt of {a} is {sqrt}");
                    }
                    Console.WriteLine("Would you like to continue? y/n");
                }
            } while (Console.ReadKey().Key == ConsoleKey.Y);
        }
    }
}
