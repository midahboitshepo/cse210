using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference and scripture instance
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference.GetDisplayText(), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Initial display
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            // Exit if user types 'quit'
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }

    }
}