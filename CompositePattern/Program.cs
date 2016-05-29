using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            int goldForKill = 1023;
            Console.WriteLine("You have killed the Giant IE6 Monster and gained {0} gold!", goldForKill);
                       
            var sophia = new Person { Name = "Sophia" };
            var brian = new Person { Name = "Brian" };

            var oldBob = new Person { Name = "Old Bob" };
            var newBob = new Person { Name = "New Bob" };
            var bobs = new Group { Name = "Bobs", Members = { oldBob, newBob } };

            var joe = new Person { Name = "Joe" };
            var jake = new Person { Name = "Jake" };
            var emily = new Person { Name = "Emily" };
            var developers = new Group { Name = "Developer", Members = { joe , jake, emily, bobs} };

                        
            var parties = new Group { Members = { developers, sophia, brian } };

            parties.Gold += goldForKill;
            parties.Stats();            

            //var totalToSplitBy = parties.Count;
            //var amountForEach = goldForKill / totalToSplitBy;
            //var leftOver = goldForKill % totalToSplitBy;


            //foreach (var partMember in parties)
            //{
            //    partMember.Gold += amountForEach + leftOver;
            //    leftOver = 0;
            //    partMember.Stats();
            //}

            //foreach (var group in groups)
            //{
            //    var amountForEachGroupMember = amountForEach / group.Members.Count;
            //    var leftOverForGroup = amountForEachGroupMember % group.Members.Count;

            //    foreach (var member in group.Members)
            //    {
            //        member.Gold += amountForEachGroupMember + leftOverForGroup;
            //        leftOverForGroup = 0;
            //        member.Stats();
            //    }
            //}

            Console.ReadLine();
        }
    }
}
