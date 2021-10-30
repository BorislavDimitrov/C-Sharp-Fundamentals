using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, List<Student>>();
            List<Student> students = new List<Student>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "no more time")
            {
                List<string> contestInfo = input
                    .Split(" -> ")
                    .ToList();
                string studentName = contestInfo[0];
                string contestName = contestInfo[1];
                int points = int.Parse(contestInfo[2]);
                Student currentStudent = new Student(studentName , points);
                Student currentIndividualStudent = new Student(studentName);

                if (!CheckIfStudentIsInList(students , studentName))
                {
                    students.Add(currentIndividualStudent);
                }
                

                if (contests.ContainsKey(contestName))
                {
                    if (CheckIfStudentExist(contests[contestName], studentName))
                    {
                        ReplaceIfBiggerPoints(contests[contestName] , currentStudent , contestName);
                    }
                    else
                    {
                        contests[contestName].Add(currentStudent);
                    }
                }
                else
                {
                    contests.Add(contestName , new List<Student>());
                    contests[contestName].Add(currentStudent);
                }
            }
            PrintContestWithStudents(contests);
            GetTotalPointsForEachStudent(contests , students);
            PrintIndividualStudentInfo(students);
        }

        public static bool CheckIfStudentExist (List<Student> students , string studentName)
        {
            bool studentExist = false;

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == studentName)
                {
                    studentExist = true;
                }
            }
            return studentExist;
        }

        public static void ReplaceIfBiggerPoints (List<Student> students , Student student , string contestName)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Points < student.Points)
                {
                    students[i].Points = student.Points;
                }
            }
        }

        public static void PrintContestWithStudents (Dictionary<string , List<Student>> contests)
        {
            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                List<Student> currentContestStudents = contest.Value;
                currentContestStudents = currentContestStudents.
                    OrderByDescending(x => x.Points).
                    ThenBy(x => x.Name).ToList();

                for (int i = 0; i < currentContestStudents.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {currentContestStudents[i].Name} <::> {currentContestStudents[i].Points}");
                }
            }
        }

        public static void GetTotalPointsForEachStudent(Dictionary<string , List<Student>> contests ,List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                foreach (var contest in contests)
                {
                    List<Student> currentContestStudents = contest.Value;

                    for (int j = 0; j < currentContestStudents.Count; j++)
                    {
                        if (currentContestStudents[j].Name == students[i].Name)
                        {
                            students[i].Points += currentContestStudents[j].Points;
                        }
                    }
                }
            }
        }

        public static void PrintIndividualStudentInfo (List<Student> students)
        {
            students = students
                .OrderByDescending(x => x.Points)
                .ThenBy(x => x.Name).ToList();
            Console.WriteLine("Individual standings:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i+1}. {students[i].Name} -> {students[i].Points}");
            }
        }

        public static bool CheckIfStudentIsInList (List<Student> students , string studentName)
        {
            bool studentExist = false;

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == studentName)
                {
                    studentExist = true;
                }
            }
            return studentExist;
        }
    }
}
