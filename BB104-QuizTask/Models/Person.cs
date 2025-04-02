namespace BB104_QuizTask.Models;

public abstract class Person
{

    private static int _id = 0;
    public Person(string name, string surname, int age)
    {
        Id = ++_id;
        Name = name;
        Surname = surname;
        Age = age;
    }
   
    public int Id { get; }
    public string Name
    {
        get => _name; set
        {
            if (value.Length > 3)
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Name max uzunluq 3 olmalidir");
                _name = "XXXXXXXXX";
            }
        }
    }
    public string Surname { get; set; }
    public int Age
    {
        get => _age; set
        {
            if (value > 0)
                _age = value;
        }
    }

    private string _name;
    private int _age;

    public override string ToString()
    {
        return $"{Name} {Surname}  {Age}";
    }

}
