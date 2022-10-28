using System;

namespace _17_PrimeNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Enter a positive number: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            Console.WriteLine("Dividers of {0}", n);
            int dividerCount = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    dividerCount++;
                }
            }

            Console.WriteLine("The number {0} is {1}prime number", n, dividerCount > 2 ? "not a " : "");
            Console.ReadLine();
        }
    }
}