using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamWorkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                List<string> teamInfo = Console.ReadLine().Split("-").ToList();
                string creatorName = teamInfo[0];
                string teamName = teamInfo[1];
                Team team = new Team(creatorName , teamName);
                bool teamExist = false;
                bool userMadeTeam = false;

                for (int j = 0; j < teams.Count; j++)
                {
                    if (teams[j].TeamName == teamName)
                    {
                        teamExist = true;
                        Console.WriteLine($"Team {teamName} was already created!");
                        break;
                    }
                }

                for (int k = 0; k < teams.Count; k++)
                {
                    if (teams[k].Creator == creatorName)
                    {
                        userMadeTeam = true;
                        Console.WriteLine($"{creatorName} cannot create another team!");
                        break;
                    }
                }

                if (!userMadeTeam && !teamExist)
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }

            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                List<string> joinMemberInfo = input.Split("->").ToList();
                string memberName = joinMemberInfo[0];
                string teamName = joinMemberInfo[1];
                Member member = new Member(memberName);
                bool teamExist = false;
                bool userAlreadyInTeam = false;

                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i].TeamName == teamName)
                    {
                        teamExist = true;
                        break;
                    }
                }

                if (!teamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                for (int j = 0; j < teams.Count; j++)
                {
                    if (teams[j].Creator == memberName)
                    {
                        userAlreadyInTeam = true;
                        Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                        break;
                    }

                    for (int i = 0; i < teams[j].Members.Count; i++)
                    {
                        if (teams[j].Members[i].Name.Contains(memberName))
                        {
                            userAlreadyInTeam = true;
                            Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                            break;
                        }
                    }
                }

                if (teamExist && !userAlreadyInTeam)
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].TeamName == teamName)
                        {
                            teams[i].Members.Add(member);
                        }
                    }
                }
            }

            List<Team> validTeams = new List<Team>();
            List<Team> invalidTeams = new List<Team>();
            
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Count > 0)
                {
                    validTeams.Add(teams[i]);
                }
                else
                {
                    invalidTeams.Add(teams[i]);
                }
            }

            invalidTeams = invalidTeams.OrderBy(team => team.TeamName).ToList();
            validTeams = validTeams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.TeamName).ToList();

            PrintTeams(validTeams);

            Console.WriteLine("Teams to disband:");

            if (invalidTeams.Count > 0)
            {
                for (int i = 0; i < invalidTeams.Count; i++)
                {
                    Console.WriteLine(invalidTeams[i].TeamName);
                }
            }
            
        }

        static void PrintTeams (List<Team> teams)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i].TeamName);
                Console.WriteLine($"- {teams[i].Creator}");

                for (int j = 0; j < teams[i].Members.Count; j++)
                {
                    
                    Console.WriteLine($"-- {teams[i].Members[j].Name}");
                }
            }
        }
    }
}
