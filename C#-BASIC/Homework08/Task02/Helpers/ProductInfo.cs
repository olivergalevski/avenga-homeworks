namespace Task02.Helpers;

    public class ProductInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }

    public ProductInfo(string title, string description)
    {
        Title = title;
        Description = description;
    }
    public override string ToString()
        {
            return
                $"Title: {Title}\n" +
                $"Description: {Description}\n";
        }
    }
