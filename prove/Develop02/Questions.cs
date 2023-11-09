public class Questions
{
    public string _question = "What was the best part of my day?, How did I see the hand of the Lord in my life today?, What was the hardest part of the day?, If I had one thing I could do over today, what would it be?, What was the strongest emotion I felt today?";
    
    List<string> question = _question.Split(",").ToList();
    public void RandomQuestion()
    {
        Random randomGenerator = new Random();
        Questions question = randomGenerator.Next(1, 11);
    }
}