using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                List<string> infos = Console.ReadLine().Split().ToList();
                string firstName = infos[0];
                string lastName = infos[1];
                double grade = double.Parse(infos[2]);

                Student student = new Student(firstName , lastName , grade);

                students.Add(student);
            }

            students = students.OrderByDescending(student => student.Grade).ToList();

            PrintStudents(students);
        }

        static void PrintStudents (List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].FirstName} {students[i].LastName}: {students[i].Grade:F2}");
            }
        }
    }
}
