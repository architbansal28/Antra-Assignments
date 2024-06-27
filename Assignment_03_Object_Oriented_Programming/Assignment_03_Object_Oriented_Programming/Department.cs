namespace Assignment_03_Object_Oriented_Programming;

public class Department
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public Department(string name, Instructor head, decimal budget, DateTime startDate, DateTime endDate)
    {
        Name = name;
        Head = head;
        Budget = budget;
        StartDate = startDate;
        EndDate = endDate;
    }
}