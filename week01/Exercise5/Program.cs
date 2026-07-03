using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, userNumber, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome! This program will square your favorite number.");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine()?.Trim() ?? "";
    }

    static int PromptUserNumber()
    {
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine()?.Trim() ?? "";

            if (int.TryParse(input, out int number))
            {
                return number;
            }

            Console.WriteLine("Please enter a valid whole number.");
        }
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int originalNumber, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of {originalNumber} is {squaredNumber}.");
    }
}