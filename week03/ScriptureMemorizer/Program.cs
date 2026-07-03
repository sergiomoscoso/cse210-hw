using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Would you like to use the default scripture or enter your own?");
        Console.WriteLine("1. Use the default scripture (John 3:16)");
        Console.WriteLine("2. Enter your own scripture");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine()?.Trim() ?? "";
        Scripture scripture;

        if (choice == "2")
        {
            Console.Write("Enter the book name: ");
            string book = Console.ReadLine()?.Trim() ?? "Unknown";

            Console.Write("Enter the chapter number: ");
            int chapter = ReadIntegerInput();

            Console.Write("Enter the starting verse: ");
            int startVerse = ReadIntegerInput();

            Console.Write("Enter the ending verse: ");
            int endVerse = ReadIntegerInput();

            Console.Write("Enter the scripture text: ");
            string text = Console.ReadLine()?.Trim() ?? "";

            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            scripture = new Scripture(reference, text);
        }
        else
        {
            Reference defaultReference = new Reference("John", 3, 16);
            string defaultText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
            scripture = new Scripture(defaultReference, defaultText);
        }

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayString());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide another word, or type 'quit' to exit.");

            string input = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (input == "quit")
            {
                keepRunning = false;
                Console.WriteLine("Goodbye! Take care.");
            }
            else
            {
                scripture.HideRandomWords(1);

                if (scripture.AreAllWordsHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayString());
                    Console.WriteLine();
                    Console.WriteLine("Congratulations! You memorized the entire scripture.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    keepRunning = false;
                }
            }
        }
    }

    static int ReadIntegerInput()
    {
        while (true)
        {
            string input = Console.ReadLine()?.Trim() ?? "";
            if (int.TryParse(input, out int value))
            {
                return value;
            }

            Console.Write("Please enter a valid number: ");
        }
    }
}