using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompantRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeesNum = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();

            for (int i = employeesNum - 1; i >= 0; i--)
            {
                List<string> info = Console.ReadLine().Split().ToList();
                string name = info[0];
                double salary = double.Parse(info[1]);
                string departmentName = info[2];

                Employee employee = new Employee(name , salary , departmentName);
                Department department = new Department(departmentName);

                if (CheckIfDepartmentExist(departments , employee))
                {
                    AddEmployeeInDepartment(departments , employee);
                }
                else
                {
                    AddDepartmentInList(departments , department);
                    AddEmployeeInDepartment(departments , employee);
                }
            }
            string biggestAverageDepart = GetBiggestAverageDepartmentSalary(departments);
            PrintBiggestAverageSalaryDepartment(departments , biggestAverageDepart);
        }
        static bool CheckIfDepartmentExist (List<Department> departments , Employee employee)
        {
            bool existDepartment = false;

            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].Name == employee.Department)
                {
                    existDepartment = true;
                }
            }

            return existDepartment;
        }
        static void AddEmployeeInDepartment (List<Department> departments , Employee employee)
        {
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].Name == employee.Department)
                {
                    departments[i].AddEmploye(employee);
                }
            }
        }
        static void AddDepartmentInList (List<Department> departments , Department department)
        {
            departments.Add(department);
        }
        static string GetBiggestAverageDepartmentSalary (List<Department> departments)
        {
            double biggestAverageSalary = 0;
            string biggestAverageSalaryDepartment = string.Empty;

            for (int i = 0; i < departments.Count; i++)
            {
                double currentDepartmentSalarySum = 0;
                double currentSalariesCount = departments[i].Employees.Count;
                double currentAverageSalary = 0;
                string currentDepartmentName = departments[i].Name;

                for (int j = 0; j < departments[i].Employees.Count; j++)
                {
                    currentDepartmentSalarySum += departments[i].Employees[j].Salary;
                    currentAverageSalary = currentDepartmentSalarySum / currentSalariesCount;

                    if (currentAverageSalary > biggestAverageSalary)
                    {
                        biggestAverageSalary = currentAverageSalary;
                        biggestAverageSalaryDepartment = currentDepartmentName;
                    }
                }
            }

            return biggestAverageSalaryDepartment;
        }
        static void PrintBiggestAverageSalaryDepartment (List<Department> departments , string departmentName)
        {
            Department newDepart = new Department();

            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].Name == departmentName)
                {
                    newDepart = departments[i];
                }
            }

            List<Employee> averageSalaryEmployees = newDepart.Employees;
            averageSalaryEmployees = averageSalaryEmployees.OrderByDescending(employee => employee.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {newDepart.Name}");

            for (int i = 0; i < averageSalaryEmployees.Count; i++)
            {
                Console.WriteLine($"{averageSalaryEmployees[i].Name} {averageSalaryEmployees[i].Salary:F2}");
            }
        }
    }
}
