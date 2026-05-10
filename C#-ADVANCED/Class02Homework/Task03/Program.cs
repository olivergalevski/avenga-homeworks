using Class02Homework.Domain.Models.Shapes;

Circle circle = new Circle(5);

Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");
Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter():F2}");

Triangle triangle = new Triangle(3, 4, 5, 4);

Console.WriteLine($"Triangle Area: {triangle.CalculateArea():F2}");
Console.WriteLine($"Triangle Perimeter: {triangle.CalculatePerimeter():F2}");