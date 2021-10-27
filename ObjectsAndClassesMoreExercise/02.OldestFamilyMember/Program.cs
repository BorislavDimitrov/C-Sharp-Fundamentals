using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int familyMembersCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < familyMembersCount; i++)
            {
                List<string> memberInfo = Console.ReadLine().Split().ToList();
                string memberName = memberInfo[0];
                int memberAge = int.Parse(memberInfo[1]);
                Member member = new Member(memberName , memberAge);
                family.AddMember(member);
            }

            Member oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
            
        }
    }
}
