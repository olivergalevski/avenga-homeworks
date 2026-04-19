Queue<int> numbers = new Queue<int>();
string choice;

do
{
    Console.WriteLine("Enter a number: ");
    int num;

    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Invalid input. Please enter a valid number: ");
    }

    numbers.Enqueue(num);

    Console.WriteLine("Do you want to enter another number? (Y/N): ");
    choice = Console.ReadLine();

}
while (string.Equals(choice, "Y", StringComparison.OrdinalIgnoreCase));

Console.WriteLine("Numbers in the order entered:");

while (numbers.Count > 0)
{
    Console.WriteLine(numbers.Dequeue());
}