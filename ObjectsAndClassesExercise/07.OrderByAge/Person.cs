using System;
using System.Collections.Generic;
using System.Text;

namespace _07.OrderByAge
{
    class Person
    {
        private string name;
        private string id;
        private int age;

        public Person(string name , string id , int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public int Age 
        {
            get => this.age;
            set => value = this.age;
        }

        public string Name
        {
            get => this.name;
            set => value = this.name;
        }

        public string Id
        {
            get => this.id;
            set => value = this.id;
        }
    }
}
