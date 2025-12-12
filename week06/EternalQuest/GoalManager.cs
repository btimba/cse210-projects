class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Initialize the goal manager
        while (true)
        {
            Console.WriteLine($"\nCurrent Score: {_score}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter short name: ");
        string shortName = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(shortName, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(shortName, description, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                
                newGoal = new CheckListGoal(shortName, description, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
      if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record an event.");
            return;
        }

        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
        Console.Write("Choice: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }
        Goal selectedGoal = _goals[index];
        selectedGoal.RecordEvent();

        bool wasComplete = selectedGoal.IsComplete();
        selectedGoal.RecordEvent();
        bool isComplete = selectedGoal.IsComplete();

        _score += selectedGoal.GetPoints();

        if (!wasComplete && isComplete && selectedGoal is CheckListGoal cl)
        {   
            _score += cl.GetBonusPoints();
            Console.WriteLine("Bonus! You earned it!");
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRep());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                // Assuming the first part indicates the goal type
                Goal goal = null;
                if (parts[0] == "SimpleGoal")
                {
                    goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                }
                else if (parts[0] == "EternalGoal")
                {
                    goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                }
                else if (parts[0] == "CheckListGoal")
                {
                    goal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                }
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}