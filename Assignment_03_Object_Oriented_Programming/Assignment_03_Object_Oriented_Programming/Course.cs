namespace Assignment_03_Object_Oriented_Programming;

public class Course
{
    public string Name { get; private set; }
    public char Grade { get; private set; }

    public Course(string name, char grade)
    {
        Name = name;
        Grade = grade;
    }

    public int GetGradePoints()
    {
        switch (Grade)
        {
            case 'A': return 4;
            case 'B': return 3;
            case 'C': return 2;
            case 'D': return 1;
            case 'F': return 0;
            default: return 0;
        }
    }
}