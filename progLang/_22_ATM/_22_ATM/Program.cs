using System;
using System.Linq;
using System.Security.AccessControl;

namespace _22_ATM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] denominations = { 20000, 10000, 5000, 2000, 1000 };
            int[] outOfDenominations = { 1000 };

            Console.Write("Withdrawal amount: ");
            int withdrawalAmount = int.Parse(Console.ReadLine());

            //check if the amount can be withdraw with the smallest available denomination
            for (int i = denominations.Length - 1; i >= 0; i--)
            {
                if (!outOfDenominations.Contains(denominations[i]) && withdrawalAmount % denominations[i] == 0)
                {
                    Console.WriteLine(
                        "The requested amount cannot be withdraw by the smallest available denomination ({0} HUF)",
                        denominations[i]);
                    break;
                }
            }

            //check if the amount can be withdraw in one denomination, if can, then break it down multiple other denominations.
            int startIndex = 0;
            for (int i = 0; i < denominations.Length; i++)
            {
                if (!outOfDenominations.Contains(denominations[i])
                    && withdrawalAmount / denominations[i] == 1
                    && withdrawalAmount % denominations[i] == 0)
                {
                    startIndex = i;
                }
            }


            //break down the amount, always use the highest available denomination. 
            for (int i = startIndex; i < denominations.Length; i++)
            {
                int denomination = denominations[i];

                if (outOfDenominations.Contains(denomination))
                    continue;


                int denominationCount = withdrawalAmount / denomination;
                if (denominationCount <= 0)
                    continue;
                Console.WriteLine($"{denominationCount} of {denomination} HUF");
                withdrawalAmount -= denominationCount * denomination;
            }
        }
    }
}