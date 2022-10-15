using System;

namespace _12_PositiveOrNegative
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            Console.Write("n = ");
            double n = double.Parse(Console.ReadLine());

            // One 'if' is required in the selection.
            if (n > 0)
            {
                Console.WriteLine("The {0} is positive.", n);
            }
            // Any number of 'else if' can be present.
            else if (n < 0)
            {
                Console.WriteLine("The {0} is negative.", n);
            }
            // Only one or zero 'else' can be present in a selection.
            else
            {
                Console.WriteLine("The {0} is not positive, neither negative.", n);
            }

            Console.ReadLine();
        }
    }
}