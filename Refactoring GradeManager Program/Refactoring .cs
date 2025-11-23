using System;

namespace Refactoring_GradeManager_Program
{
    public class GradeManager
    {
        public double passingGrade = 50.0;

        public static void DoWork()
        {
            Console.WriteLine("Working on grades...");
        }

        public void ProcessGrades(string studentName, double[] grades)
        {
            Console.WriteLine("Processing grades for " + studentName);

            double total = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }
            double average = total / grades.Length;
            Console.WriteLine("Average: " + average);

            if (average >= passingGrade)
            {
                Console.WriteLine("Status: Pass");
            }
            else
            {
                Console.WriteLine("Status: Fail");
            }
        }

        public static double CalculateFinalGrade(double bonus, double average)
        {
            return average + bonus;
        }
    }
}