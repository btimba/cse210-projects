using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;

        while (number != 0)
        {
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }

        float average = (float)total / numbers.Count;
        
        int largest = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
            
    }
}