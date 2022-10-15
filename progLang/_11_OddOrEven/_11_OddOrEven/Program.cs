using System;

namespace _11_OddOrEven
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("The {0} is even.", n);
            }
            else
            {
                Console.WriteLine("The {0} is odd.", n);
            }
            Console.ReadLine();
        }
    }
}