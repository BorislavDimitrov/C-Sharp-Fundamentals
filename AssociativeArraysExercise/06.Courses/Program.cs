using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var courses = new Dictionary<string , List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> courseInfo = input.Split(" : ").ToList();
                string courseName = courseInfo[0];
                string studentName = courseInfo[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName , new List<string>());
                    courses[courseName].Add(studentName);
                }
            }
            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key , y => y.Value);
            PrintCourses(courses);
        }

        public static void PrintCourses (Dictionary<string , List<string>> courses)
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                List<string> names = courses[course.Key].OrderBy(x => x).ToList();

                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine($"-- {names[i]}");
                }
            }
        }
    }
}
