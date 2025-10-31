using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("What is the magic number?");
       // string reply = Console.ReadLine();

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("What is your guess?");
        string guessString = Console.ReadLine();
        int guess = int.Parse(guessString);
        if (guess < magicNumber)
        {
            Console.WriteLine("Higher!");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower!");
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed it!");
        }

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guessString = Console.ReadLine();
            guess = int.Parse(guessString);
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
        }
    }
}