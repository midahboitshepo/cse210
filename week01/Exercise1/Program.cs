using System;

class Program
{
    static void Main(string[] args)
    {
        String firstName;
        Console.WriteLine("What is your first name?");
        firstName = Console.ReadLine();

        String lastName;
        Console.WriteLine("What is your last name?");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}