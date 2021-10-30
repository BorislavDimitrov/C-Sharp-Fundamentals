using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsPoints = new Dictionary<string, int>();
            var programmingLanguageSubmitions = new Dictionary<string, int>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                List<string> command = input.Split("-" , StringSplitOptions.RemoveEmptyEntries).ToList();
                string studenName = command[0];
                string language = string.Empty;
                int points = 0;
                

                if (command.Count == 3)
                {
                    
                    language = command[1];
                    points = int.Parse(command[2]);

                    if (studentsPoints.ContainsKey(studenName))
                    {
                        if (studentsPoints[studenName] < points)
                        {
                            studentsPoints[studenName] = points;
                        }
                        
                    }
                    else
                    {
                        studentsPoints.Add(studenName , points);
                    }

                    if (programmingLanguageSubmitions.ContainsKey(language))
                    {
                        programmingLanguageSubmitions[language]++;
                    }
                    else
                    {
                        programmingLanguageSubmitions.Add(language , 1);
                    }
                }
                else if (command.Count == 2)
                {                   
                    studentsPoints.Remove(studenName);
                }
            }

            studentsPoints = studentsPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key , y => y.Value);
            PrintStudents(studentsPoints);

            programmingLanguageSubmitions = programmingLanguageSubmitions.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key , y => y.Value);
            PrintProgrammingLanguages(programmingLanguageSubmitions);
        }

        public static void PrintStudents (Dictionary<string , int> studentsPoints)
        {
            Console.WriteLine("Results:");
            foreach (var student in studentsPoints)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
        }

        public static void PrintProgrammingLanguages (Dictionary<string , int> programingLanguagesSubmitions)
        {
            Console.WriteLine("Submissions:");

            foreach (var language in programingLanguagesSubmitions)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
