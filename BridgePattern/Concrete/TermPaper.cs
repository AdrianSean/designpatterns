﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class TermPaper : Manuscript
    {
        public TermPaper(IFormatter formatter) : base(formatter)
        {

        }

        public string Class { get; set; }

        public string Student { get; set; }

        public string Text { get; set; }

        public string References { get; set; }

        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Class: ", Class));
            Console.WriteLine(_formatter.Format("Students: ", Student));
            Console.WriteLine(_formatter.Format("Text: ", Text)); 
            Console.WriteLine(_formatter.Format("References: ", References));
        }
    }
}
