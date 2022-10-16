using System;

namespace _01_06_VaccineExpiryDate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Vaccination year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Vaccination month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Vaccination day: ");
            int day = int.Parse(Console.ReadLine());

            DateTime vaccineDate = new DateTime(year, month, day);
            int expiryDays = 182;
            Console.WriteLine(vaccineDate.AddDays(expiryDays).ToShortDateString());
            
        }
    }
}