using System;

namespace _01_08_RateOfInterest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Calculate the earned interests, by the formula: To(1 + p / 100) ^ n where
            // To the principal
            // p the rate of interest
            // n number of years
            Console.Write("Enter the principal value (HUF): ");
            int principal = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of years: ");
            int years = int.Parse(Console.ReadLine());
            Console.Write("Enter the rate of interest (%): ");
            double rate = double.Parse(Console.ReadLine());

            double interest = principal * Math.Pow(1 + rate / 100, years) / 1_000_000;
            
            Console.WriteLine($"Your interests will be (million HUF): {interest:0.000}");
            Console.ReadLine();
        }
    }
}