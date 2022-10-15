using System;

namespace _15_Iteration
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Use 'while' when you don't know the number of iterations and you need to test for every iteration.
            // Write out the numbers while you find the first number which is bigger than 29 and can be divided by 7.
            int n = 1;
            while (n <= 29 || n % 7 != 0)
            {
                //Console.WriteLine(n);
                n++;
            }
            
            // Print out the numbers which are not bigger than 100.
            int k = 1;
            while(k <= 100){
                Console.WriteLine(k);
                k++;
            }
            
            // When you know the exact number of iterations.
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}