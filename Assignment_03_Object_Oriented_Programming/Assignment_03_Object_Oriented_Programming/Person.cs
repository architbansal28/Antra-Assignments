namespace Assignment_03_Object_Oriented_Programming;

public abstract class Person
{
    public string Name { get; private set; }
    public DateTime BirthDate { get; private set; }
    private List<string> addresses = new List<string>();

    public Person(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    public abstract decimal CalculateSalary();

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return addresses;
    }
}