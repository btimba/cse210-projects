using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLoader
{
    public static List<Scripture> LoadFromFile(string filePath)
    {
        var scriptures = new List<Scripture>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: File not found.");
            return scriptures;
        }

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("Book|"))
            {
                continue; // Skip empty lines and header
            }
            string[] parts = line.Split('|');
            if (parts.Length >= 4)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                string versePart = parts[2];
                string text = parts[3];

                int verse;
                int verseEnd = versePart.Contains("-") ? int.Parse(versePart.Split('-')[1]) : int.Parse(versePart);

                Reference reference;
                if (versePart.Contains("-"))
                {
                    verse = int.Parse(versePart.Split('-')[0]);
                    reference = new Reference(book, chapter, verse, verseEnd);
                }
                else
                {
                    verse = int.Parse(versePart);
                    reference = new Reference(book, chapter, verse);
                }

                Scripture scripture = new Scripture(reference, text);
                scriptures.Add(scripture);
            }
        }
        return scriptures;
    }
}