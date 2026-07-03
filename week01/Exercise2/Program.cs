using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine()?.Trim() ?? "";

        if (!int.TryParse(input, out int grade) || grade < 0 || grade > 100)
        {
            Console.WriteLine("Please enter a valid percentage from 0 to 100.");
            return;
        }

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            int lastDigit = grade % 10;

            if (letter == "A")
            {
                sign = lastDigit < 3 ? "-" : "";
            }
            else
            {
                sign = lastDigit >= 7 ? "+" : lastDigit < 3 ? "-" : "";
            }
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep practicing. You can do better next time.");
        }
    }
}