using Class02Homework.Domain.Models.Company;

Manager manager = new Manager("Alice", "Alison", 3000, 500);
Programmer programmer = new Programmer("Bob", "Bobsky", 25, 160);

Console.WriteLine(manager.DisplayInfo());

Console.WriteLine(programmer.DisplayInfo());