namespace BB104_QuizTask.Models;

public class Student : Person
{
    public double Grade
    {
        get => _grade; set
        {
            if (value >= 0 && value <= 100)
            {
                _grade = value;
            }
        }
    }
    private double _grade;
    public Student(string name, string surname, int age, double grade) : base(name, surname, age)
    {
        Grade = grade;
    }

    public override string ToString()
    {
        return $"{Id}-  {Name} {Surname} {Age}  Grade- {Grade}";
    }
}
