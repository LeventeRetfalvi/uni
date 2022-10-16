using System;

namespace _01_03_DistanceBetweenPoints
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Find the distance between two given points.
            // Ask for the coordinates
            Console.Write("Enter the first point first coordinate(x1): ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the first point second coordinate(y1): ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second point first coordinate(x2): ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second point second coordinate(y2): ");
            int y2 = int.Parse(Console.ReadLine());

            // Calculate the distance
            double distnace = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            // Print the result.
            Console.WriteLine("The distance between the points is {0:0.000}.", distnace);
            Console.ReadLine();
        }
    }
}