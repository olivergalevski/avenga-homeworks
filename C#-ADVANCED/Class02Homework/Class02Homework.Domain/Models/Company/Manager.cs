namespace Class02Homework.Domain.Models.Company
{
    public class Manager : Employee
    {
        public int MonthlySalary { get; set; }
        public int Bonus { get; set; }

        public Manager(string name, string lastname, int monthlySalary, int bonus)
            : base(name, lastname)
        {
            MonthlySalary = monthlySalary;
            Bonus = bonus;
        }
        public override int CalculateSalary()
        {
            return MonthlySalary + Bonus;
        }
        public override string DisplayInfo()
        {
            return
                "Manager Information \n" +
                $"Name: {GetFullName()} \n" +
                $"Salary: {CalculateSalary()} \n";
        }
    }
}
