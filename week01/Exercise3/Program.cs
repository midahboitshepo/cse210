using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 0;
        int userGuess = -1;
        Random random = new Random();
        magicNumber = random.Next(1, 101); // Generates a number between 1 and 10
        Console.WriteLine("What is the magic number ?" + magicNumber); // For testing purposes

        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess ? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}
