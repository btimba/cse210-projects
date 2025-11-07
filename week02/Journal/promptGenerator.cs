public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What are my goals for tomorrow?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Any spiritual thoughts I want to record?"
    };
    public string GetRandomPrompt()
    {
        // Method to get a random prompt from a predefined list
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
          
    }
}


