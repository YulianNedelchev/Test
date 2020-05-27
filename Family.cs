using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class Family
    {
        public Family()
        {
            this.FamilyMembers=new List<Person>();
        }
        public List<Person> FamilyMembers {get; set; }

        public void AddMember(Person member)
        {
            this.FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.FamilyMembers
                .OrderByDescending(x => x.Age)
                .First();
        }
    }
}
