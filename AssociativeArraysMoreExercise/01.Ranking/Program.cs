using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestsPasswords = new Dictionary<string, string>();
            List<Student> students = new List<Student>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                List<string> contestInfo = input.Split(':').ToList();
                string contestName = contestInfo[0];
                string contestPass = contestInfo[1];

                contestsPasswords.Add(contestName , contestPass);
            }

            string input2 = string.Empty;

            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                List<string> submissionInfo = input2.Split("=>").ToList();
                string contestName = submissionInfo[0];
                string contestPass = submissionInfo[1];
                string studentName = submissionInfo[2];
                int studentPoints = int.Parse(submissionInfo[3]);

                Contest currentContest = new Contest(contestName ,studentPoints );
                Student currentStudent = new Student(studentName);

                if (contestsPasswords.ContainsKey(contestName))
                {
                    if (contestsPasswords[contestName] == contestPass)
                    {
                        if (CheckIfStudentExist(students , studentName))
                        {
                            if (CheckIfContestExist(students , studentName ,contestName))
                            {
                                ReplacePointsIfHigher(students, contestName, studentName, studentPoints);
                            }
                            else
                            {
                                AddNewContest(students , studentName , currentContest);
                            }
                        }
                        else
                        {
                            AddNewStudent(students , currentStudent , currentContest);
                        }
                    }
                }
            }

            PrintBestPointsStudent(BestTotalPoints(students));
            PrintAllStudents(students);
            
        }

        public static bool CheckIfStudentExist (List<Student> students , string studentName)
        {
            bool studentExist = false;

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == studentName)
                {
                    studentExist = true;
                    break;
                }
            }
            return studentExist;
        }

        public static void ReplacePointsIfHigher (List<Student> students , string contestName , string studentName , int studentPoints)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == studentName)
                {
                    for (int j = 0; j < students[i].Contest.Count; j++)
                    {
                        if (students[i].Contest[j].Name == contestName)
                        {
                            if (students[i].Contest[j].Points < studentPoints)
                            {
                                students[i].Contest[j].Points = studentPoints;
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void AddNewStudent (List<Student> students , Student student , Contest contest)
        {
            students.Add(student);

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == student.Name)
                {
                    students[i].Contest.Add(contest);
                }
            }
        }

        public static bool CheckIfContestExist (List<Student> students ,string studentName, string contestName)
        {
            bool contestExist = false;

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == studentName)
                {
                    for (int j = 0; j < students[i].Contest.Count; j++)
                    {
                        if (students[i].Contest[j].Name == contestName)
                        {
                            contestExist = true;
                        }
                    }
                }
            }
            return contestExist;
        }

        public static void AddNewContest (List<Student> students ,string studentName , Contest contest)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == studentName)
                {
                    students[i].Contest.Add(contest);
                }
            }
        }

        public static Student BestTotalPoints (List<Student> students)
        {
            Student bestPointsStudent = new Student();
            int bestPoints = 0;

            for (int i = 0; i < students.Count; i++)
            {
                int currentStudentPoints = 0;

                for (int j = 0; j < students[i].Contest.Count; j++)
                {
                    currentStudentPoints += students[i].Contest[j].Points;

                    if (currentStudentPoints > bestPoints)
                    {
                        bestPoints = currentStudentPoints;
                        bestPointsStudent = students[i];
                    }
                }
            }
            return bestPointsStudent;
        }

        public static void PrintBestPointsStudent (Student bestPointsStudent)
        {
            int bestPoints = 0;

            for (int i = 0; i < bestPointsStudent.Contest.Count; i++)
            {
                bestPoints += bestPointsStudent.Contest[i].Points;
            }

            Console.WriteLine($"Best candidate is {bestPointsStudent.Name} with {bestPoints} points.");
        }

        public static void PrintAllStudents (List<Student> students)
        {
            students = students.OrderBy(x => x.Name).ToList();
            Console.WriteLine("Ranking:");

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].Name);
                List<Contest> currentContests = students[i].Contest.OrderByDescending(x => x.Points).ToList();

                for (int j = 0; j < currentContests.Count; j++)
                {
                    Console.WriteLine($"# {currentContests[j].Name} -> {currentContests[j].Points}");
                }
            }
        }
    }
}
