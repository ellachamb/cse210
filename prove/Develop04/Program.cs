using System;

class Program
{
    static void Main(string[] args)
    {
        Listing listing = new Listing();
        Reflecting reflecting = new Reflecting();
        Breathing breathing = new Breathing();
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness App");
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Show Activity Log");
        Console.WriteLine("   5. Exit");
        Console.Write("Select a choice from menu: ");
        string choice = Console.ReadLine();
        while (choice != "5")
        {
            switch (choice)
            {
                case "1":
                    breathing.DisplayStartMessage();
                    Console.Write("How long, in seconds, would you like for your session? ");
                    int duration = int.Parse(Console.ReadLine());
                    breathing.SetDuration(duration);
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    breathing.ShowSpinner(2);
                    breathing.DisplayBreathingIntervals(duration);
                    breathing.DisplayEndMessage();
                    break;
                case "2":
                    reflecting.DisplayStartMessage();
                    Console.Write("How long, in seconds, would you like for your session? ");
                    int duration2 = int.Parse(Console.ReadLine());
                    reflecting.SetDuration(duration2);
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    reflecting.ShowSpinner(2);
                    string prompt = reflecting.GetRandomPrompt();
                    reflecting.DisplayPrompts(prompt, duration2);
                    reflecting.DisplayEndMessage();
                    break;
                case "3":
                    listing.DisplayStartMessage();
                    Console.Write("How long, in seconds, would you like for your session? ");
                    int duration3 = int.Parse(Console.ReadLine());
                    listing.SetDuration(duration3);
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    listing.ShowSpinner(2);
                    listing.DisplayPrompts(duration3);
                    listing.DisplayEndMessage();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Activity Log");
                    Console.WriteLine("   Breathing: " + breathing.GetBreathingCount() + " completed");
                    Console.WriteLine("   Reflecting: " + reflecting.GetReflectingCount() + " completed");
                    Console.WriteLine("   Listing: " + listing.GetListingCount() + " completed");
                    Console.WriteLine("Press enter to go back to menu: ");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Activity Log");
            Console.WriteLine("   5. Exit");
            Console.Write("Select a choice from menu: ");
            choice = Console.ReadLine();
        }

    }
}