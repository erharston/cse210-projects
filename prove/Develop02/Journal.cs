public class Journal
{
    public List<Questions> _questions = new List<Questions>();

    foreach (Questions question in _question)
    {
        Console.WriteLine($"{question}");
    }
}