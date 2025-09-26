public class Video 
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> Comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {Comments.Count}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.DisplayInfo();
        }
    }
}