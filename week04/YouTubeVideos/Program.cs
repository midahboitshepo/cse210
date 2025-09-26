using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("You Matter to Him", "President Dieter F. Uchtdorf", 300);
        Video video2 = new Video("The First Great Commandment", "Elder Jeffrey R. Holland", 600);
        Video video3 = new Video("Dare to Stand Alone", "President Thomas S. Monson", 450);

        // Add comments to video1
        video1.AddComment(new Comment("joseph1", "This is one of my favorites"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User1", "God continues to speak through you"));

        // Add comments to video2
        video2.AddComment(new Comment("User3", "I learned a lot from this."));
        video2.AddComment(new Comment("User4", "This talk spoke to me like no other prophets words have."));
        video2.AddComment(new Comment("User2", "This is by far one of my favorite conference talks"));

        // Add comments to video3
        video3.AddComment(new Comment("amanda34", "I love and miss you President Monson!"));
        video3.AddComment(new Comment("awhibaby", "You never stand alone when you stand with your father in heaven "));
        video3.AddComment(new Comment("wholyodi", "Thomas S. Monson is a true and living prophet of God the almighty."));

        // Display information about the videos
        video1.DisplayInfo();
        Console.WriteLine();
        video2.DisplayInfo();
        Console.WriteLine();
        video3.DisplayInfo();
        Console.WriteLine();
        // Keep the console window open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}