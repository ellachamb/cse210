using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();
        Video video1 = new Video("Video 1", "John Smith", "10:00");
        video1.AddComment(new Comment("CrazyDog2", "I love this!"));
        video1.AddComment(new Comment("wild775", "Wow so cool."));
        video1.AddComment(new Comment("josephrgfw", "Crazy!"));
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Jacob Wilde", "8:50");
        video2.AddComment(new Comment("laughinghard", "What is this??"));
        video2.AddComment(new Comment("maryalewis", "I don't get it."));
        video2.AddComment(new Comment("caleb99485", "This is amazing!"));
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Elizabeth Christensen", "20:45");
        video3.AddComment(new Comment("garybs299", "I love this!"));
        video3.AddComment(new Comment("barrybarry2", "I can't stop watching."));
        video3.AddComment(new Comment("strawberrylover0", "This madee my day:))"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.Print();
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine();
        }
    }
}