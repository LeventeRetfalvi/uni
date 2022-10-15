using System;

namespace _17_PrimeDividers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Enter a positive integer: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

            int dividerCount = 0;
            Console.WriteLine("Dividers of {0}:", n);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    dividerCount++;
                }
            }
            Console.WriteLine("The {0} is {1}", n, dividerCount == 2 ? "prime." : "is not prime.");

            Console.ReadLine();
        }
    }
}