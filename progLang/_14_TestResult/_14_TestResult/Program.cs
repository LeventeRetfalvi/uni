using System;

namespace _14_TestResult
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the test's maximal score: ");
            int maxScore;
            if (int.TryParse(Console.ReadLine(), out maxScore) && 10 <= maxScore && maxScore <= 100)
            {
                Console.Write("Enter the actual score: ");
                int actualScore;
                if (int.TryParse(Console.ReadLine(), out actualScore) && 0 <= actualScore && actualScore <= maxScore)
                {
                    double percentage = (double)actualScore / maxScore * 100;
                    Console.WriteLine("Test result: {0:0.00}%", percentage);
                    if (percentage < 50) Console.WriteLine("E");
                    else if (percentage < 60) Console.WriteLine("D");
                    else if (percentage < 70) Console.WriteLine("C");
                    else if (percentage < 80) Console.WriteLine("B");
                    else if (percentage < 100) Console.WriteLine("A");
                    else Console.WriteLine("A+");
                }
                else
                {
                    Console.WriteLine("Error! Value must be between {0} and {1}.", 0, maxScore);
                }
            }
            else
            {
                Console.WriteLine("Error! Value must be between {0} and {1}", 10, 100);
            }

            Console.ReadLine();
        }
    }
}