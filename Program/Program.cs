using System;

namespace Refactoring_GradeManager_Program
{
    public class GradeManager
    {
        public double passingGrade = 50.0;

        public void doWork()
        {
            Console.WriteLine("Working on grades...");
        }

        public void processGrades(string studentName, double[] grades)
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

        public double calculateFinalGrade(double bonus, double average)
        {
            return average + bonus;
        }
    }
}