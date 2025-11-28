using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       // create videos 
    Video v1 = new Video("UltraSkin Lotion","Johnsons",300);
    Video v2 = new Video("Raptor","Ford",350);
    Video v3 = new Video("Creamy Cheddar","Taits",250);
    
    //add comments to v1
    v1.AddComment(new Comment("Brian","Great for skin care!"));
    v1.AddComment(new Comment("Linda","Loving it."));
    v1.AddComment(new Comment("Brenda","Perfect for my skin tone."));

    //add comments to v2
    v2.AddComment(new Comment("Bruce","Powerful machine, what a beast!"));
    v2.AddComment(new Comment("Brian","Great invention."));
    v2.AddComment(new Comment("Ben","Thanks for posting this."));

    //add comments to v3
    v3.AddComment(new Comment("Sarah","In love already."));
    v3.AddComment(new Comment("Joe","Soo tasty."));
    v3.AddComment(new Comment("Gina","Yummy yummy."));

    List<Video> videos = new List<Video>(){v1, v2, v3};

    foreach (Video video in videos)
    {
        Console.WriteLine($"Title: {video.GetTitle()}");
        Console.WriteLine($"Author: {video.GetAuthor()}");
        Console.WriteLine($"Length: {video.GetLength()} seconds");
        Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in video.GetComments())
        {
            Console.WriteLine($" - {comment.GetName()}: {comment.GetText()}");
        }

        Console.WriteLine();

    }
    }
}
