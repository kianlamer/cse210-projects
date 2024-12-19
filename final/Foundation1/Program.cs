using System;

class Program
{
    static void Main(string[] args)
    {
         List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Understanding C# Classes", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "I love this tutorial."));
        video1.AddComment(new Comment("Charlie", "Could you explain more about inheritance?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Data Science with C#", "Jane Smith", 450);
        video2.AddComment(new Comment("Dave", "Very informative!"));
        video2.AddComment(new Comment("Eva", "What libraries are used in the examples?"));
        video2.AddComment(new Comment("Frank", "Nice content!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Machine Learning Basics in C#", "Alice Johnson", 600);
        video3.AddComment(new Comment("Grace", "I learned a lot from this video!"));
        video3.AddComment(new Comment("Hank", "Can you share more resources?"));
        videos.Add(video3);

        // Iterate through the list of videos and display their information
        foreach (var video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine("\n" + new string('=', 40) + "\n"); // Separator between videos
        }
    }
}