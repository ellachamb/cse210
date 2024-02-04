using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userInput = "1";

        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;

                    journal._entries.Add(entry);
                    break;
                case "2":
                    foreach (Entry singleEntry in journal._entries)
                    {
                        Console.WriteLine($"{singleEntry._entryDate}");
                        Console.WriteLine($"{singleEntry._prompt}");
                        Console.WriteLine($"{singleEntry._response}");
                    }
                    break;
                case "3":
                    string fileName = journal.NameFile();
                    journal.LoadFile(fileName);
                    break;
                case "4":
                    string fileName1 = journal.NameFile();
                    journal.SaveFile(fileName1, journal._entries);
                    break;
                case "5":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}