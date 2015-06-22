using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulSharp.Console.Models
{
    class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string RelativeFileLocation { get; set; }
        public Publisher Publisher { get; set; }
        public string PageReference { get; set; }
        public AuthorArticle[] Authors { get; set; }
    }
}
