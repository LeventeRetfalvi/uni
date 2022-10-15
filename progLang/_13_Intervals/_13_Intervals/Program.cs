using System;

namespace _13_Intervals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("You entered {0}", n);
            }
            else
            {
                Console.WriteLine("Error! It is not a number!");
                return;
            }

            // [-inf, 4) U [12; inf]
            // 'AND' and 'OR' operators
            // n <4 || 12 <= n
            if (!(4 <= n && n < 12))
            {
                Console.WriteLine("The entered number is good!");
            }
            else
            {
                Console.WriteLine("The entered number is wrong!");
            }

            Console.ReadLine();
        }
    }
}