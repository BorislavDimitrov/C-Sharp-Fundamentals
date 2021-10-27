using System;
using System.Collections.Generic;
using System.Text;

namespace _01.CompantRoster
{
    class Department
    {
        private string name;
        private List<Employee> employees = new List<Employee>();

        public Department()
        {

        }
        public Department(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get => name;
            set => value = name;
        }

        public List<Employee> Employees
        {
            get => employees;
            set => value = employees;
        }

        public void AddEmploye (Employee employee)
        {
            employees.Add(employee);
        }
    }
}
