using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }


        public Student(string firstName , string lastName , double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
