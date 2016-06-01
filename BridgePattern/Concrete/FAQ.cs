using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class FAQ : Manuscript
    {
        public FAQ(IFormatter formatter) : base(formatter)
        {
            Questions = new Dictionary<string, string>();
        }

        public string Title { get; set; }

        public Dictionary<string, string> Questions { get; set; }

        
        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Title: ", Title));
            foreach (var question in Questions)
            {
                Console.WriteLine(_formatter.Format("   Question: ", question.Key));
                Console.WriteLine(_formatter.Format("   Answer: ", question.Value));
            }
            Console.WriteLine();
        }

    }
}
