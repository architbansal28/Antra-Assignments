using Assignment_03_Object_Oriented_Programming;

class Program
{
    static void Main(string[] args)
    {
        // Methods Task
        int[] numbers = GenerateNumbers(10);
        Reverse(numbers);
        PrintNumbers(numbers);

        // Fibonacci Task
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
        }

        // OOP Tasks
        Student student = new Student("John Doe", new DateTime(2000, 5, 1));
        student.EnrollInCourse(new Course("Math", 'A'));
        student.EnrollInCourse(new Course("Science", 'B'));
        Console.WriteLine($"Student GPA: {student.CalculateGPA()}");

        Instructor instructor = new Instructor("Dr. Smith", new DateTime(1980, 10, 15), new DateTime(2005, 8, 20));
        Console.WriteLine($"Instructor Salary: {instructor.CalculateSalary()}");

        // Color and Ball Task
        Color redColor = new Color(255, 0, 0);
        Ball redBall = new Ball(10, redColor);

        redBall.Throw();
        redBall.Throw();
        redBall.Pop();
        redBall.Throw();

        Console.WriteLine($"Red ball has been thrown {redBall.ThrowCount} times.");
    }

    static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    static void Reverse(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    static void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static int Fibonacci(int n)
    {
        if (n <= 2)
            return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
