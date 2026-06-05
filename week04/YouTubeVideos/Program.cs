using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 30 Minutes", "Programming Hub", 1800);
        video1.AddComment(new Comment("John", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Emma", "Thanks for explaining clearly."));
        video1.AddComment(new Comment("David", "Great video."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Football Goals", "Sports TV", 900);
        video2.AddComment(new Comment("Alex", "Amazing goals!"));
        video2.AddComment(new Comment("Sarah", "Goal number 3 was incredible."));
        video2.AddComment(new Comment("Mike", "Loved this compilation."));
        videos.Add(video2);

        Video video3 = new Video("Traveling in Albania", "Travel World", 1200);
        video3.AddComment(new Comment("Anna", "Beautiful country."));
        video3.AddComment(new Comment("Chris", "I want to visit Albania."));
        video3.AddComment(new Comment("Linda", "Great places shown."));
        videos.Add(video3);

        Video video4 = new Video("How to Cook Pizza", "Food Master", 1500);
        video4.AddComment(new Comment("Tom", "Looks delicious!"));
        video4.AddComment(new Comment("Jessica", "Trying this tonight."));
        video4.AddComment(new Comment("Robert", "Easy to follow recipe."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comment List:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}