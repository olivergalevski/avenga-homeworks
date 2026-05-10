using Class02Homework.Domain.Models.Shapes;

Rectangle rectangle = new Rectangle(5, 4);
Circle circle = new Circle(3);
Triangle triangle = new Triangle(6, 2);

Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");
Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
Console.WriteLine($"Triangle Area: {triangle.GetArea():F2}");