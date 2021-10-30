using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            var numbers = new Dictionary<string , List<double>>();

            for (int i = 0; i < numberOfInput; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (numbers.ContainsKey(name))
                {
                    numbers[name].Add(grade);
                }
                else
                {
                    numbers.Add(name , new List<double>());
                    numbers[name].Add(grade);
                }
            }

            var collectionWithHighAverageGrades = GetHigherAverageGradeStudents(numbers);
            collectionWithHighAverageGrades = collectionWithHighAverageGrades.OrderByDescending(x => x.Value).ToDictionary(x => x.Key , y => y.Value);
            PrintStudents(collectionWithHighAverageGrades);
        }

        public static Dictionary<string , double> GetHigherAverageGradeStudents (Dictionary<string , List<double>> allStudents)
        {
            var collectionWithHighAverageGrades = new Dictionary<string, double>();

            foreach (var student in allStudents)
            {
                double[] currentGrades = student.Value.ToArray();
                double averageGrade = currentGrades.Average();

                if (averageGrade >= 4.50)
                {
                    collectionWithHighAverageGrades.Add(student.Key ,averageGrade );
                }
            }
            return collectionWithHighAverageGrades;
        }

        public static void PrintStudents (Dictionary<string , double> averageGradesStudents)
        {
            foreach (var student in averageGradesStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
