using Class02Homework.Domain.Interfaces;

namespace Class02Homework.Domain.Models
{
    public class WebPage : ISearchable
    {
        public string Url { get; set; }
        public string Content { get; set; }

        public WebPage(string url, string content)
        {
            Url = url;
            Content = content;
        }

        public bool Search(string word)
        {
            return Content.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}