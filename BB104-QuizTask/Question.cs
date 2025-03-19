namespace BB104_QuizTask;

public class Question
{
    public string Text;
    public Variant[] Variants;

    public Question(string text, Variant[] variants)
    {
        Text = text;
        Variants = variants;
    }
}
