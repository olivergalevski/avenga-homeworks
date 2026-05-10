namespace Class02Homework.Domain.Models.Company
{
    public class Programmer : Employee
    {
        public int HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Programmer(string name, string lastname, int hourlyRate, int hoursWorked)
            : base(name, lastname)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override int CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
        public override string DisplayInfo()
        {
            return
                "Programmer Information \n" +
                $"Name: {GetFullName()} \n" +
                $"Salary: {CalculateSalary()} \n";
        }
    }
}
