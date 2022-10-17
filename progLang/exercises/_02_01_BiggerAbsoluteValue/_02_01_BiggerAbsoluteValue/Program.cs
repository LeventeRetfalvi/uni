using System;

namespace _02_01_BiggerAbsoluteValue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a) > Math.Abs(b))
            {
                Console.WriteLine("The first number ({0}) has the bigger absolute value.", a);
            }
            else if (Math.Abs(a) < Math.Abs(b))
            {
                Console.WriteLine("The second number ({0}) has the bigger absolute value.", b);
            }
            else
            {
                Console.WriteLine("The two numbers ({a} and {b}) has the same absolute value.");
            }

            Console.ReadLine();
        }
    }
}