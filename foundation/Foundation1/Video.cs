using System;

namespace Foundation1;

public class Video
{
   public string Title { get; set; }
    public string Author { get; set; }
    public TimeSpan Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, TimeSpan length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayComments()
    {
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
    }
}
