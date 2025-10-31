using System;

class Program
{
    static void Main(string[] args)



    {
        Console.WriteLine("What is your grade percentage?");
        string reply = Console.ReadLine();
        int gradePercentage = int.Parse(reply);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is F.");
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't be discouraged! Keep trying and you'll do better next time.");
        }

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
       
       Console.WriteLine($"Your grade is {letter}.");
    }
}