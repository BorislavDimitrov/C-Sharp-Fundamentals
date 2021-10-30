using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Judge
{
    class Student
    {
        private string name;
        private int points;

        public Student()
        {

        }

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name , int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Points
        {
            get => points;
            set => points = value;
        }
    }
}
