namespace Assignment_03_Object_Oriented_Programming;

public class Student : Person
{
    private List<Course> courses = new List<Course>();

    public Student(string name, DateTime birthDate) : base(name, birthDate)
    {
    }

    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
    }

    public double CalculateGPA()
    {
        int totalPoints = 0;
        foreach (var course in courses)
        {
            totalPoints += course.GetGradePoints();
        }
        return (double)totalPoints / courses.Count;
    }

    public override decimal CalculateSalary()
    {
        return 0; // Students don't have a salary
    }
}