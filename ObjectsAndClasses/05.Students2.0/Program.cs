using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split().ToList();
                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string city = command[3];

                Student student = new Student();
                student.firstName = firstName;
                student.lastName = lastName;
                student.age = age;
                student.city = city;

                bool contains = false;

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].firstName == firstName && students[i].lastName == lastName)
                    {
                        contains = true;
                    }
                }

                if (contains)
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        if (students[i].firstName == firstName && students[i].lastName == lastName)
                        {
                            students[i].age = age;
                            students[i].city = city;
                            break;
                        }
                    }
                }
                else
                {
                    students.Add(student);
                }
            }

            string cityPrint = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].city == cityPrint)
                {
                    PrintStudent(students[i]);
                }
            }
        }

        static void PrintStudent(Student student)
        {
            Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
        }
    }
}
