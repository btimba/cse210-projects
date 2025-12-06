

public class ListingActivity : Activity
{
    
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);
        string selectedPrompt = _prompts[promptIndex];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {selectedPrompt} ---");
        Console.WriteLine("You may begin in 3 seconds...");
        Countdown(3);

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items!");
        DisplayEndingMessage();
        ActivityLog["Listing"] ++;
    }
}
