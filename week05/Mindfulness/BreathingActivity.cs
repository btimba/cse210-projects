public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by guiding you through deep breathing exercises.")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.WriteLine("Get ready to begin...");
        Spinner(7);

        int inhaleTime = 4;
        int exhaleTime = 6;
        int cycles = _duration / (inhaleTime + exhaleTime);
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            BreathingBar(true, inhaleTime);
            Console.WriteLine("Breathe out...");
            BreathingBar(false, exhaleTime);
        }
        DisplayEndingMessage();
        ActivityLog["Breathing"] ++
    }
}   

    