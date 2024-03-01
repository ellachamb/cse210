using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Exit");
        Console.Write("Select a choice from menu: ");
        string choice = Console.ReadLine();
        while (choice != "4")
        {
            switch (choice)
            {
                case "1":
                    Breathing breathing = new Breathing();
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
                    Reflecting reflecting = new Reflecting();
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
                    Listing listing = new Listing();
                    listing.DisplayStartMessage();
                    Console.Write("How long, in seconds, would you like for your session? ");
                    int duration3 = int.Parse(Console.ReadLine());
                    listing.SetDuration(duration3);
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    listing.ShowSpinner(2);
                    // Console.WriteLine();
                    // listing.DisplayListingIntervals();
                    // listing.DisplayEndMessage();
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
            Console.WriteLine("   4. Exit");
            Console.Write("Select a choice from menu: ");
            choice = Console.ReadLine();
        }

    }
}