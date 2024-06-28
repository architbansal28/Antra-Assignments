using Assignment_04_Generics;

class Program
{
    static void Main(string[] args)
    {
        // Testing MyStack<T>
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine($"Stack Count: {stack.Count()}"); // Output: 3
        Console.WriteLine($"Popped: {stack.Pop()}"); // Output: 3
        Console.WriteLine($"Stack Count: {stack.Count()}"); // Output: 2

        // Testing MyList<T>
        MyList<string> myList = new MyList<string>();
        myList.Add("Hello");
        myList.Add("World");
        myList.InsertAt("C#", 1);
        Console.WriteLine($"Element at index 1: {myList.Find(1)}"); // Output: C#
        Console.WriteLine($"Contains 'World': {myList.Contains("World")}"); // Output: True
        myList.Remove(1);
        myList.DeleteAt(1);
        myList.Clear();
        Console.WriteLine($"MyList Count after Clear: {myList.Count}"); // Output: 0

        // Testing GenericRepository<T>
        GenericRepository<Entity> repository = new GenericRepository<Entity>();
        var entity1 = new Entity { Id = 1 };
        var entity2 = new Entity { Id = 2 };
        repository.Add(entity1);
        repository.Add(entity2);
        foreach (var entity in repository.GetAll())
        {
            Console.WriteLine($"Entity ID: {entity.Id}");
        }
        var entityById = repository.GetById(1);
        Console.WriteLine($"Entity fetched by ID 1: {entityById.Id}");
        repository.Remove(entity1);
        repository.Save();
    }
}
