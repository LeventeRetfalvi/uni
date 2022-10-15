using System;

namespace _16_ValidatedInput
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Enter an integer number from [10; 20): ");    
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 10 || 20 <= n);

            double k;
            do
            {
                Console.Write("Enter a real number from [10, 20): ");
            } while (!double.TryParse(Console.ReadLine(), out k) || k < 10 || 20 <= k);
        }
    }
}