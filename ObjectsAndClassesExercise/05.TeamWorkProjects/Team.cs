using System;
using System.Collections.Generic;
using System.Text;

namespace _05.TeamWorkProjects
{
    public class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<Member> Members { get; set; } = new List<Member>();

        public Team(string creator , string teamName)
        {
            TeamName = teamName;
            Creator = creator;
        }

        
    }
}
