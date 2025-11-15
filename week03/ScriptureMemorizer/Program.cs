using System;

class Program
{
    static void Main(string[] args)
    {
        //Added feature to load scriptures from a file.
        
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

        string input = Console.ReadLine();

        if (input.ToLower() == "quit")
        {
            return;
        }

        List<Scripture> scriptures = ScriptureLoader.LoadFromFile("scriptures.txt");
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures loaded. Exiting program.");
            return;
        }
        Random rand = new Random();
        Scripture selectedScripture = scriptures[rand.Next(scriptures.Count)];
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());

            if (selectedScripture.IsCompletelyHidden())
            {
                break;
            }
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            selectedScripture.HideRandomWords(3);
        }


    }
}