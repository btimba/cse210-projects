using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int choice = 0;

        while (choice != 5)
        {
            myJournal.ShowMenu();

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                myJournal.AddEntry();
            }
            else if (choice == 2)
            {
                myJournal.DisplayEntries();
            }
            else if (choice == 3)
            {
                myJournal.SaveToFile();
            }
            else if (choice == 4)
            {
                myJournal.LoadFromFile();
            }   
            else if (choice > 5)
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
           
        }

        Console.WriteLine("Journal closed. Goodbye!");

    }
}