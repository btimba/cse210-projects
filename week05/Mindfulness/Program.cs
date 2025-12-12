using System;
using System.Collections.Generic;
using System.Threading;

partial class Program
{
    static void Main(string[] args)
    // Added Keeping a log of how many times activities were performed.

    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Start();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please select a number between 1 and 4.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
        
}