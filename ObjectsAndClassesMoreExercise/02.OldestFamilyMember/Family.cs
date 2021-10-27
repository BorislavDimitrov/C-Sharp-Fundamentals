using System;
using System.Collections.Generic;
using System.Text;

namespace _02.OldestFamilyMember
{
    class Family
    {
        List<Member> members = new List<Member>();

        public List<Member> Members
        {
            get => members;
            set => value = members;
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public Member GetOldestMember()
        {
            int oldestAge = 0;
            Member oldestMember = new Member();

            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Age > oldestAge)
                {
                    oldestAge = members[i].Age;
                    oldestMember = members[i];
                }
            }

            return oldestMember;
        }
    }
}
