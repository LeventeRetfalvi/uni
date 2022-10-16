using System;

namespace _1_5_StudentTrainTicket
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the travelling distance (km): ");
            int distance = int.Parse(Console.ReadLine());
            int sections = distance / 11 + 1;
            int sectionPrice = 210;
            double studentDiscount = 0.5;
            int ticketPrice = Convert.ToInt32(sections * sectionPrice * studentDiscount);
            int ticketPriceRounded = ticketPrice % 100 >= 50 ? (ticketPrice / 100 + 1) * 100 : ticketPrice / 100 * 100;
            Console.WriteLine($"Student ticket price: {ticketPriceRounded}");
            Console.ReadLine();
        }
    }
}