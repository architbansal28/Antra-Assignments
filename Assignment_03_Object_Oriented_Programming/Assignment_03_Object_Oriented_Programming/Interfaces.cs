namespace Assignment_03_Object_Oriented_Programming;

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
}

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    double CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    int CalculateExperience();
}

public interface ICourseService
{
    int GetGradePoints();
}

public interface IDepartmentService
{
    decimal CalculateBudget();
}