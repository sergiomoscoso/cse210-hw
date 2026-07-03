using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine()?.Trim() ?? "";

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine()?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("Please enter both names.");
            return;
        }

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}