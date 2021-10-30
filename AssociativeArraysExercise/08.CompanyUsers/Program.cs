using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companiesEmployees = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> companyInfo = input.Split(" -> ").ToList();
                string companyName = companyInfo[0];
                string companyId = companyInfo[1];

                if (companiesEmployees.ContainsKey(companyName))
                {
                    if (!CheckIfIdExist(companiesEmployees , companyName , companyId))
                    {
                        companiesEmployees[companyName].Add(companyId);
                    }
                }
                else
                {
                    companiesEmployees.Add(companyName ,new List<string>());
                    companiesEmployees[companyName].Add(companyId);
                }
            }

            companiesEmployees = companiesEmployees.OrderBy(x => x.Key).ToDictionary(x => x.Key , y => y.Value);
            Print(companiesEmployees);
        }

        public static bool CheckIfIdExist (Dictionary<string , List<string>> companiesEmployees , string companyName, string employeeId)
        {
            bool idExist = false;

            for (int i = 0; i < companiesEmployees[companyName].Count; i++)
            {
                if (companiesEmployees[companyName][i] == employeeId)
                {
                    idExist = true;
                }
            }
            return idExist;
        }

        public static void Print(Dictionary<string , List<string>> companiesEmployees)
        {
            foreach (var company in companiesEmployees)
            {
                Console.WriteLine(company.Key);
                for (int i = 0; i < companiesEmployees[company.Key].Count; i++)
                {
                    Console.WriteLine($"-- {companiesEmployees[company.Key][i]}");
                }
            }
        }
    }
}
