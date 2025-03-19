namespace BB104_QuizTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Variant variant1 = new Variant("4", true);
            Variant variant2 = new Variant("1");
            Variant variant3 = new Variant("2");
            Variant variant4 = new Variant("3");

            Variant variant5 = new Variant("Salam");
            Variant variant6 = new Variant("1");
            Variant variant7 = new Variant("2", true);
            Variant variant8 = new Variant("3");

            Variant[] variants1 = [variant1, variant2, variant3, variant4];
            Variant[] variants2 = [variant5, variant6, variant7, variant8];


            Question question1 = new Question("Filin nece ayagi var?", variants1);
            Question question2 = new Question("Toyugun nece ayagi var?", variants2);

            Question[] questions = [question1, question2];


            Quiz quiz = new Quiz("BB104 Quiz", questions);



        }
    }
}
