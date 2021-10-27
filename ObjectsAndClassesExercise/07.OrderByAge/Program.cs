using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> info = input.Split().ToList();
                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);

                Person person = new Person(name , id , age);
                people.Add(person);
                
            }

            people = people.OrderBy(person => person.Age).ToList();
            PrintPeople(people);
        }

        static void PrintPeople(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{people[i].Name} with ID: {people[i].Id} is {people[i].Age} years old.");
            }
        }
    }
}
