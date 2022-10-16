using System;

namespace _19_ProgrammingTheorems
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Sum the numbers.
            int sum = 0;
            int multiply = 1;
            int min = int.MaxValue;
            bool hasEven = false;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. szám = ", i);
                int n = int.Parse(Console.ReadLine());

                sum += n;
                multiply *= n;
                if (n < min)
                    min = n;
                if (n % 2 == 0)
                    hasEven = true;
            }

            Console.WriteLine("The sum of numbers: {0}", sum);
            Console.WriteLine("The multiplication of numbers: {0}", sum);
            Console.WriteLine("The smallest number: {0}", min);
            Console.WriteLine("There is {0} even number.", hasEven ? "at least one" : "not any");

            Console.ReadLine();
        }
    }
}