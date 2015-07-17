namespace PaulSharp.Console.Models
{
    internal class Article
    {
        public Article()
        {
        }

        public AuthorArticle[] Authors { get; set; }
        public int Id { get; set; }
        public string PageReference { get; set; }
        public Publisher Publisher { get; set; }
        public string RelativeFileLocation { get; set; }
        public string Title { get; set; }
    }
}