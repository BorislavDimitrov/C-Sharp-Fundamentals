using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Ranking
{
    class Student
    {
        private string name;
        private List<Contest> contests = new List<Contest>();


        public Student()
        {

        }

        public Student(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Contest> Contest
        {
            get => contests;
            set => contests = value;
        }
    }
}
