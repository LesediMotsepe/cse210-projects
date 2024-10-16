using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        
             var video1 = new Foundation1.Video("C# Basics", "John Doe", TimeSpan.FromMinutes(10));
        video1.AddComment(new Foundation1.Comment("Jane Doe", "Great intro to C#!"));
        video1.AddComment(new Foundation1.Comment("Bob Smith", "Very informative!"));
        video1.AddComment(new Foundation1.Comment("Alice Johnson", "Love the examples!"));

        var video2 = new Foundation1.Video("C# Advanced", "Jane Doe", TimeSpan.FromMinutes(20));
        video2.AddComment(new Foundation1.Comment("John Doe", "Excellent explanation!"));
        video2.AddComment(new Foundation1.Comment("Bob Smith", "Too complex for beginners."));
        video2.AddComment(new Foundation1.Comment("Mike Brown", "Helpful for my project!"));

        var video3 = new Foundation1.Video("C# Best Practices", "Bob Smith", TimeSpan.FromMinutes(15));
        video3.AddComment(new Foundation1.Comment("Jane Doe", "Very useful tips!"));
        video3.AddComment(new Foundation1.Comment("John Doe", "Agree with the author."));
        video3.AddComment(new Foundation1.Comment("Emily Davis", "Will apply these principles!"));

        var video4 = new Foundation1.Video("C# and AI", "Mike Brown", TimeSpan.FromMinutes(30));
        video4.AddComment(new Foundation1.Comment("John Doe", "Fascinating topic!"));
        video4.AddComment(new Foundation1.Comment("Jane Doe", "Looking forward to more content."));
        video4.AddComment(new Foundation1.Comment("Bob Smith", "Well-explained concepts!"));

         var videoList = new List<Foundation1.Video> { video1, video2, video3, video4 };
        

        {
            Console.WriteLine($"Title: {video1.Title}");
            Console.WriteLine($"Author: {video1.Author}");
            Console.WriteLine($"Length: {video1.Length}");
            Console.WriteLine($"Comments: {video1.GetCommentCount()}");
            Console.WriteLine("Comments:");
            video1.DisplayComments();
            Console.WriteLine(new string('-', 30));
        }
    

    }
}