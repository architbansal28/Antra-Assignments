namespace Assignment_03_Object_Oriented_Programming;

public class Instructor : Person
{
    public DateTime JoinDate { get; private set; }
    public bool IsHeadOfDepartment { get; set; }

    public Instructor(string name, DateTime birthDate, DateTime joinDate) : base(name, birthDate)
    {
        JoinDate = joinDate;
    }

    public int CalculateExperience()
    {
        return DateTime.Now.Year - JoinDate.Year;
    }

    public override decimal CalculateSalary()
    {
        decimal baseSalary = 50000;
        int experience = CalculateExperience();
        return baseSalary + (experience * 1000);
    }
}