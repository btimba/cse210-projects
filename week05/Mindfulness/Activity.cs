     

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }

    //Animation methods
    protected void Spinner(int duration)
    {
        List<string> frames = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        int i=0;
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i % frames.Count]);
            Thread.Sleep(450);
            Console.Write("\b \b");
            i= (i+1) % frames.Count;
        }
    }
    
    public void DotLoader(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.Write("\b\b\b   \b\b\b");
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void BreathingBar(bool inhale,int seconds)
    {
        int steps = 12;
        int delay = (seconds * 1000) / steps;

        for (int i = 0; i <= steps; i++)
        {
            int length = inhale ? i : steps - i;
            Console.Write("\r[" + new string('#', length) + new string(' ', steps - length) + "]");
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }

    public static Dictionary<string, int> ActivityLog = new Dictionary<string, int>();
    {
        {"Breathing", 0},
        {"Reflecting", 0},
        {"Listing", 0}
    }
}; 
