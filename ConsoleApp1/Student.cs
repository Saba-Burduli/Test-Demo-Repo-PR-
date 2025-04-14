namespace ConsoleApp1;

public class Student
{
    public string Name { get; set; }
    public string LastName { get; set; }    
    public Student(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{Name} {LastName}";
    }
}
