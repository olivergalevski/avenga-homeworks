using Class02Homework.Domain.Models;

Document document = new Document(
    "C# Notes",
    "Interfaces are very useful in C#"
);

WebPage webPage = new WebPage(
    "https://avenga.csharpadvanced.com",
    "Welcome to the C# advanced tutorial website"
);

Console.WriteLine(document.Search("interfaces"));
Console.WriteLine(webPage.Search("tutorial"));