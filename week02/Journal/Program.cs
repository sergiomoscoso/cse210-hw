using System;
using System.IO;

// Creativity: This program exceeds requirements by automatically loading the journal on startup
// and asking to save before quitting to prevent data loss.

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        string defaultFilename = "journal.txt";

        // Automatically load existing journal if it exists
        if (File.Exists(defaultFilename))
        {
            Console.WriteLine("Existing journal found. Loading...");
            myJournal.LoadFromFile(defaultFilename);
        }

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("\n=== Journal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DateTime currentDate = DateTime.Now;
                string dateText = currentDate.ToShortDateString();

                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry(dateText, prompt, response);
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added!");
            }
            else if (choice == "2")
            {
                if (myJournal.EntryCount == 0)
                {
                    Console.WriteLine("Your journal is empty. Write your first entry.");
                }
                else
                {
                    myJournal.DisplayAllEntries();
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save (or press Enter for default): ");
                string filename = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(filename))
                {
                    filename = defaultFilename;
                }

                myJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load (or press Enter for default): ");
                string filename = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(filename))
                {
                    filename = defaultFilename;
                }

                myJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.Write("Do you want to save before quitting? (yes/no): ");
                string saveChoice = Console.ReadLine();

                if (saveChoice.ToLower() == "yes")
                {
                    myJournal.SaveToFile(defaultFilename);
                }

                keepRunning = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("❌ Invalid option. Please choose 1-5.");
            }
        }
    }
}