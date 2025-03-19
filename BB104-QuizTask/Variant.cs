namespace BB104_QuizTask;

public class Variant
{
    public string Content;
    public bool IsCorrect;

    public Variant(string content, bool isCorrect = false)
    {
        Content = content;
        IsCorrect = isCorrect;
    }
}


