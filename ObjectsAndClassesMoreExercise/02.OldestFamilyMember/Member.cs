using System;
using System.Collections.Generic;
using System.Text;

namespace _02.OldestFamilyMember
{
    class Member
    {
        private string name;
        private int age;

        public Member(string name , int age)
        {
            this.name = name;
            this.age = age;
        }

        public Member()
        {
                
        }

       public string Name
        {
            get => name;
            set => value = name;
        }

        public int Age
        {
            get => age;
            set => value = age;
        }
    }
}
