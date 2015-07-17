using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaulSharp.Console.Models;

namespace PaulSharp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher()
            {
                Id = 1,
                Location = "New York",
                Title = "Mother Earth, Mother Board",
                Year = new MyDate(2003),
            };
            var author1= new Author()
            {
                Id = 1,
                Name = "Neal Stephenson"
            };
            var authorarticle1 = new AuthorArticle()
            {
                Author = author1,
                SequenceNumber = 1
            };
            var author2 = new Author()
            {
                Id = 2,
                Name = "Kushal Hada"
            };
            var authorarticle2 = new AuthorArticle()
            {
                Author = author2,
                SequenceNumber = 2
            };
            var article = new Article()
            {
                Id = 1,
                Authors = new AuthorArticle[2],
                PageReference = "7-12",
                Publisher = publisher,
                RelativeFileLocation = "1.pdf",
                Title = "Mother Earth, Mother Board"
            };
            article.Authors[0] = authorarticle1;
            article.Authors[1] = authorarticle2;
            System.Console.WriteLine("done");
        }
    }
}
