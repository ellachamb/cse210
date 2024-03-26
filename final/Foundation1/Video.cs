public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Length { get; set; }
    List<Comment> Comments { get; set; }

    public Video(string title, string author, string length)
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

    public void Print()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}

