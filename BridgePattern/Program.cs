using System;
using System.Collections.Generic;


namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Manuscript> documents = new List<Manuscript>();

            var standFormatter = new StandardFormatter();
            var faq = new FAQ(standFormatter);
            faq.Title = "The Bridge Pattern FAq";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to seperate an abstraction from an implementation");
            documents.Add(faq);


            var backwardsFormatter = new BackwardsFormatter();
            var book = new Book (backwardsFormatter)
            {
                Title = "Design Patterns",
                Author = "Adrian Gurnett",
                Text = "Blah blah blah"
            };
            documents.Add(book);


            var fancyFormatter = new FancyFormatter();
            var paper = new TermPaper(fancyFormatter) {
                Class = "Design Patterns",
                Student = "Joe N00b",
                Text = "Blah blah blah",
                References = "GOF"
            };
            documents.Add(paper);


            foreach (var document in documents)
                document.Print();
            

            Console.ReadKey();
        }      
    }
}
