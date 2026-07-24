using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all videos
        List<Video> videoList = new List<Video>();

        // --- Create Video 1 ---
        Video video1 = new Video("CSE 210 Week 04 Overview", "Brother Barker", 180);
        video1.AddComment(new Comment("Alice", "Great explanation of abstraction!"));
        video1.AddComment(new Comment("Bob", "I finally understand lists inside classes."));
        video1.AddComment(new Comment("Charlie", "Thanks for the clear examples."));
        videoList.Add(video1);

        // --- Create Video 2 ---
        Video video2 = new Video("How to Code in C#", "CodeMaster", 300);
        video2.AddComment(new Comment("Dave", "Very helpful tutorial."));
        video2.AddComment(new Comment("Eve", "Could you do one on encapsulation next?"));
        videoList.Add(video2);

        // --- Create Video 3 ---
        Video video3 = new Video("Understanding Git", "DevGuru", 240);
        video3.AddComment(new Comment("Frank", "Git push is scary at first."));
        video3.AddComment(new Comment("Grace", "Practice makes perfect!"));
        video3.AddComment(new Comment("Heidi", "Love the visual diagrams."));
        videoList.Add(video3);

        // --- Iterate and Display ---
        Console.WriteLine("--- YouTube Video Tracker ---\n");
        
        foreach (Video video in videoList)
        {
            // Calls the method that displays title, author, length, count, and comments
            video.DisplayDetails();
        }
    }
}