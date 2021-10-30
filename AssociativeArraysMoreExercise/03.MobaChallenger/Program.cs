using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MobaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, Dictionary<string, int>>();
            var totalPoints = new Dictionary<string, int>();
            
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Season end")
            {
                List<string> checkCommand = input.Split().ToList();
                string playerName = string.Empty;
                string secondCommand = string.Empty;
                int skillPoints = 0;
                var tempPositions = new Dictionary<string, int>();

                if (checkCommand.Contains("->"))
                {
                    List<string> newPositionInfo = input.Split(" -> ").ToList();
                    playerName = newPositionInfo[0];
                    secondCommand = newPositionInfo[1];
                    skillPoints = int.Parse(newPositionInfo[2]);

                    if (players.ContainsKey(playerName))
                    {
                        if (players[playerName].ContainsKey(secondCommand))
                        {
                            if (players[playerName][secondCommand] < skillPoints)
                            {
                                totalPoints[playerName] -= players[playerName][secondCommand];
                                totalPoints[playerName] += skillPoints;
                                players[playerName][secondCommand] = skillPoints;
                            }
                        }
                        else
                        {                           
                            players[playerName].Add(secondCommand , skillPoints);
                            totalPoints[playerName] += skillPoints;
                        }
                    }
                    else
                    {
                        tempPositions.Add(secondCommand , skillPoints);
                        players.Add(playerName , tempPositions);
                        totalPoints.Add(playerName , skillPoints);

                    }
                }
                else
                {
                    List<string> playerBattle = input.Split(" vs ").ToList();
                    playerName = playerBattle[0];
                    secondCommand = playerBattle[1];

                    if (players.ContainsKey(playerName) && players.ContainsKey(secondCommand))
                    {
                        if (CheckIfPlayersHaveCommonPositions(players , playerName , secondCommand))
                        {
                            int firstPlayerPoints = CalculatePlayerTotalPoints(players , playerName);
                            int secondPlayerPoinst = CalculatePlayerTotalPoints(players , secondCommand);

                            if (firstPlayerPoints > secondPlayerPoinst)
                            {
                                players.Remove(secondCommand);
                                totalPoints.Remove(secondCommand);
                            }
                            else if (secondPlayerPoinst > firstPlayerPoints)
                            {
                                players.Remove(playerName);
                                totalPoints.Remove(playerName);
                            }
                        }
                    }
                }
            }

            PrintPlayers(totalPoints , players);
        }

        public static bool CheckIfPlayersHaveCommonPositions (Dictionary<string , Dictionary<string , int>> players ,
            string firstPlayerName , string secondPlayerName)
        {
            bool haveCommon = false;
            List<string> firstPlayerPositions = new List<string>();
            List<string> secondPlayerPositions = new List<string>();

            foreach (var position in players[firstPlayerName])
            {
                firstPlayerPositions.Add(position.Key);
            }

            foreach (var position in players[secondPlayerName])
            {
                secondPlayerPositions.Add(position.Key);
            }

            for (int i = 0; i < firstPlayerPositions.Count; i++)
            {
                for (int j = 0; j < secondPlayerPositions.Count; j++)
                {
                    if (firstPlayerPositions[i] == secondPlayerPositions[j])
                    {
                        haveCommon = true;
                        break;
                    }
                }
            }
            return haveCommon;
        }

        public static int CalculatePlayerTotalPoints (Dictionary<string , Dictionary<string , int>> players , string playerName)
        {
            int totalPoints = 0;

            foreach (var position in players[playerName])
            {
                totalPoints += position.Value;
            }
            return  totalPoints;
        }

        public static void PrintPlayers(Dictionary<string , int> totalPoints , Dictionary<string , Dictionary<string , int>> players)
        {
            totalPoints = totalPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key , y => y.Value);

            foreach (var player in totalPoints)
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                players[player.Key] = players[player.Key]
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key , y => y.Value);

                foreach (var position in players[player.Key])
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
