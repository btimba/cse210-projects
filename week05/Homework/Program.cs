using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Brian", "Trigonometry");
        Console.WriteLine(assignment.GetSummary());
        Mathematics mathAssignment = new Mathematics("Brian", "Trigonometry", "Section 2.4", "1-10 odd");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Writing writingAssignment = new Writing("Tessa", "European History", "The French Revolution");
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }


}