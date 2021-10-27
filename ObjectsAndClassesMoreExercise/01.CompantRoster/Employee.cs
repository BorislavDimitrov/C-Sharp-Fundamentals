using System;
using System.Collections.Generic;
using System.Text;

namespace _01.CompantRoster
{
    class Employee
    {
        private string name;
        private double salary;
        private string department;

        public Employee(string name ,double salary , string department)
        {
            this.name = name;
            this.salary = salary;
            this.department = department;
        }

        public string Name
        {
            get => name;
            set => value = name;
        }

        public double Salary
        {
            get => salary;
            set => value = salary;
        }

        public string Department
        {
            get => department;
            set => value = department;
        }
    }
}
