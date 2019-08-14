using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class Family
    {
        private List<Person> familyMembers;
        public Family()
        {
            familyMembers = new List<Person>();
        }
        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        }
        public void AddMemberCon(Person member)
        {
            if(member.Age > 30)
            {
                familyMembers.Add(member);
            }
        }
        public Person GetOldestMember()
        {
            Person oldestPerson = familyMembers.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestPerson;
        }

    }
}
