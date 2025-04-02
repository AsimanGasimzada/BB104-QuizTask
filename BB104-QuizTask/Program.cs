using BB104_QuizTask.Models;

namespace BB104_QuizTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] Students = [];

            restart:

            Console.WriteLine("1.Studentleri goster");
            Console.WriteLine("2.Student yarat");

            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    PrintStudents(Students);
                    break;

                case "2":
                    Students = CreateStudent(Students);
                    break;

                default:
                    Console.WriteLine("Duzgun deyer daxil edin");
                    break;
            }

            goto restart;

        }

         static void PrintStudents(Student[] Students)
        {
            Console.Clear();
            foreach (var st in Students)
            {
                Console.WriteLine(st);
            }
        }

        static Student[] CreateStudent(Student[] Students)
        {
            Console.Clear();

            Console.WriteLine("Name daxil edin:");
            string name = Console.ReadLine();


            Console.WriteLine("Surname daxil edin");
            string surname = Console.ReadLine();

            Console.WriteLine("Age daxil edin");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Grade daxil edin");
            double grade = double.Parse(Console.ReadLine());


            Student student = new(name, surname, age, grade);


            Array.Resize(ref Students, Students.Length + 1);
            Students[^1] = student;

            Console.WriteLine("Student ugurla yaradildi");
            return Students;
        }
    }
}
