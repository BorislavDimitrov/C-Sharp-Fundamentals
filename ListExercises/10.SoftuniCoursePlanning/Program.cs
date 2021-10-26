using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftuniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courseProgram = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                List<string> command = input.Split(':').ToList();
                string firstCommand = command[0];
                string secondTextCommand = command[1];
                string thirdTextCommand = string.Empty;
                int thirdNumberCommand = 0;
                bool isThirdElementNumber = false;

                if (command.Count == 3)
                {
                    thirdTextCommand = command[2];
                    isThirdElementNumber = int.TryParse(command[2], out thirdNumberCommand);
                }

                if (firstCommand == "Add")
                {
                    AddLesson(courseProgram , secondTextCommand);
                }
                else if (firstCommand == "Insert")
                {
                    InsertLessonAtIndex(courseProgram , secondTextCommand , thirdNumberCommand);
                }
                else if (firstCommand == "Remove")
                {
                    RemoveLesson(courseProgram , secondTextCommand);
                }
                else if (firstCommand == "Swap")
                {
                    SwapLessonsByIndexes(courseProgram , secondTextCommand , thirdTextCommand);
                }
                else if (firstCommand == "Exercise")
                {
                    ExerciseAdd(courseProgram , secondTextCommand);
                }
                
            }
            for (int i = 0; i < courseProgram.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courseProgram[i]}");
            }
        }


        static void AddLesson (List<string> courseProgram , string lessonTitle)
        {
            if (!courseProgram.Contains(lessonTitle))
            {
                courseProgram.Add(lessonTitle);
            }
        }

        static void InsertLessonAtIndex (List<string> courseProgram , string lessonTitle , int indexToInsert)
        {
            if (!courseProgram.Contains(lessonTitle))
            {
                courseProgram.Insert(indexToInsert , lessonTitle);
            }
        }

        static void RemoveLesson(List<string> courseProgram , string lessonTitle)
        {
            if (courseProgram.Contains(lessonTitle))
            {
                string exercise = $"{lessonTitle}-Exercise";
                courseProgram.Remove(lessonTitle);
                if (courseProgram.Contains(exercise))
                {
                    courseProgram.Remove(exercise);
                }
            }
        }

        static void SwapLessonsByIndexes (List<string> courseProgra , string firstLessonTitle , string secondLessonTitle)
        {
            if (courseProgra.Contains(firstLessonTitle) && courseProgra.Contains(secondLessonTitle))
            {
                int firstLessonTitleIndex = courseProgra.IndexOf(firstLessonTitle);
                int secondLessonTitleIndex = courseProgra.IndexOf(secondLessonTitle);

                courseProgra[firstLessonTitleIndex] = secondLessonTitle;
                courseProgra[secondLessonTitleIndex] = firstLessonTitle;

                string exerciseFristLesson = $"{firstLessonTitle}-Exercise";
                string exerciseSecondLesson = $"{secondLessonTitle}-Exercise";

                if (courseProgra.Contains(exerciseFristLesson))
                {
                    courseProgra.Remove(exerciseFristLesson);
                    if (secondLessonTitleIndex > courseProgra.Count - 1)
                    {
                        courseProgra.Add(exerciseFristLesson);
                    }
                    else
                    {
                        courseProgra.Insert(secondLessonTitleIndex + 1, exerciseFristLesson);
                    }
                    
                }

                if (courseProgra.Contains(exerciseSecondLesson))
                {
                    courseProgra.Remove(exerciseSecondLesson);
                    if (firstLessonTitleIndex > courseProgra.Count - 1)
                    {
                        courseProgra.Add(exerciseSecondLesson);
                    }
                    else
                    {
                        courseProgra.Insert(firstLessonTitleIndex + 1, exerciseSecondLesson);
                    }
                    
                }
            }
        }

        static void ExerciseAdd(List<string> courseProgram, string lessonTitle )
        {
            int indexOfLesson = courseProgram.IndexOf(lessonTitle);
            string exercise = $"{lessonTitle}-Exercise";

            if (courseProgram.Contains(lessonTitle) && !courseProgram.Contains(exercise))
            {
                courseProgram.Insert(indexOfLesson + 1 , $"{lessonTitle}-Exercise");
            }
            else if (!courseProgram.Contains(lessonTitle) && !courseProgram.Contains(exercise))
            {
                courseProgram.Add(lessonTitle);
                courseProgram.Add($"{lessonTitle}-Exercise");
            }
        }
    }
}
