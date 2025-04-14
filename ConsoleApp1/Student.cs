namespace ConsoleApp1;

public class Student
{
    public string Name { get; }
    public string LastName { get; }
    public int Age { get; set; }

    public Student(string name, string lastName, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} {LastName}";
    }
}
