using System;

namespace _1_4_DegreesToRadians
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Convert degrees to radians
            Console.Write("Enter degrees to convert: ");
            double degrees = double.Parse(Console.ReadLine());
            
            double radians = degrees / Math.PI / 180;
            double piRadians = degrees / 180;
            
            Console.WriteLine("Degree in radians: {0}", radians);
            Console.WriteLine("Degree in pi-radians: {0}", piRadians);
            Console.ReadLine();
        }
    }
}