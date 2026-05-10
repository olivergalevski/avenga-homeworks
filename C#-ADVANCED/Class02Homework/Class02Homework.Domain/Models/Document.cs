using Class02Homework.Domain.Interfaces;

namespace Class02Homework.Domain.Models
{
    public class Document : ISearchable
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public Document(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public bool Search(string word)
        {
            return Text.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}