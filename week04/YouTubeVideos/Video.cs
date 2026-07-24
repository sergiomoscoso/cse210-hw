using System;
using System.Collections.Generic;

public class Video
{
    // Attributes (Private)
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>(); // Initialize the list
    }

    // Methods
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        // Returns the count directly from the list (Composition requirement)
        return _comments.Count;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Video: {_title} by {_author} ({_lengthSeconds} seconds)");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        
        // Iterate through the internal list to display comments
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetCommentText()}");
        }
        Console.WriteLine(); // Blank line for readability
    }
}