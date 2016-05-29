using System;
using System.Collections.Generic;

namespace CompositePattern
{
    internal class Group : IParty
    {
        public List<IParty> Members { get; internal set; }
        public string Name { get; set; }

        public Group()
        {
            Members = new List<IParty>();
        }

        public int Gold
        {
            get
            {
                int totalGold = 0;
                foreach (var member in Members)
                {
                    totalGold += member.Gold;
                }
                return totalGold;
            }

            set
            {
                var eachSplit = value / Members.Count;
                var leftover = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftover;
                    leftover = 0; // ensure that first person in the list gets the leftover and then just clear it.
                }
            }
        }       


        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}