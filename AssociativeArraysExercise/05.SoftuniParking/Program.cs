using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var parkingLots = new Dictionary<string ,string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                string firstCommand = command[0];
                string username = command[1];
                string licensePlate = string.Empty;

                if (command.Count == 3)
                {
                    licensePlate = command[2];
                }

                if (firstCommand == "register")
                {
                    Register(parkingLots , username , licensePlate);
                }
                else if (firstCommand == "unregister")
                {
                    Unregister(parkingLots , username);
                }
            }

            PrintRegisteredUsers(parkingLots);
        }

        public static void Register (Dictionary<string,string> parkingLots,string username , string licensePlate)
        {
            if (parkingLots.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {parkingLots[username]}");
            }
            else
            {
                parkingLots.Add(username , licensePlate);
                Console.WriteLine($"{username} registered {licensePlate} successfully");
            }
        }

        public static void Unregister (Dictionary<string , string> parkingLots , string username)
        {
            if (parkingLots.ContainsKey(username))
            {
                Console.WriteLine($"{username} unregistered successfully");
                parkingLots.Remove(username);
            }
            else
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
        }

        public static void PrintRegisteredUsers (Dictionary<string , string> parkingLots)
        {
            foreach (var user in parkingLots)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
