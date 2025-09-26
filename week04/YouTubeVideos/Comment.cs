public class Comment
{
    public string _username;
    public string _text;

    public Comment(string username, string text)
    {
        _username = username;
        _text = text;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Username: {_username}");
        Console.WriteLine($"Comment: {_text}");
    }
}