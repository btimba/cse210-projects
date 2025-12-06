public class ReflectingActivity : Activity
{
    
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a challenge.",
        "Recall a moment when you felt truly at peace.",
        "Reflect on a recent accomplishment you're proud of.",
        "Consider a time when you helped someone in need."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How can you apply this experience in the future?",
        "What emotions did you feel during this time?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity helps you reflect on meaningful experiences in your life.")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.WriteLine("Take a moment to think about the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        DotLoader(5);
        Console.WriteLine("Now, consider the following questions:");
        foreach (string question in _questions)
        {
            Console.WriteLine($"- {question}");
            DotLoader(10);
        }
        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }

    public void DisplayQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        string question = _questions[index];
        Console.WriteLine($"- {question}");
    }
    ActivityLog["Reflecting"] ++;
}
