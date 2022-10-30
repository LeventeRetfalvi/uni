using System;

namespace _21_AverageOfTests
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of students in the class: ");
            int studentsCount = int.Parse(Console.ReadLine());

            int[] grades = new int[studentsCount];
            int sum = 0;
            for (int i = 0; i < studentsCount; i++)
            {
                Console.Write("#{0} grade: ", i + 1);
                int grade = int.Parse(Console.ReadLine());
                grades[i] = grade;
                sum += grade;
            }

            double avg = (double)sum / studentsCount;
            Console.WriteLine("The average of grades is {0:0.00}", avg);

            int betterThanAverageCount = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > avg)
                {
                    betterThanAverageCount++;
                }
            }

            Console.WriteLine("{0} students had better test than the average.", betterThanAverageCount);

            Console.ReadLine();
        }
    }
}