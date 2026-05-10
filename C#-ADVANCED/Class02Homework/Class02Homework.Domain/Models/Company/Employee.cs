namespace Class02Homework.Domain.Models.Company
{
    public abstract class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Employee(string firstName, string lastName)
        {
            Firstname = firstName;
            Lastname = lastName;
        }
        public string GetFullName()
        {
            return $"{Firstname} {Lastname}";
        }
        public abstract int CalculateSalary();
        public abstract string DisplayInfo();
    }
}
