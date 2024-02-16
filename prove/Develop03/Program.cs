using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer! Enter the information for the book you want to memorize.");
        Console.Write("Please enter the book: ");
        string book = Console.ReadLine();
        Console.Write("Please enter the chapter: ");
        string chapter = Console.ReadLine();
        Console.Write("Please enter the verse number: ");
        string verse = Console.ReadLine();
        Console.Write("Please enter the end verse number (if there is only one verse enter 'N/A': ");
        string endVerse = Console.ReadLine();
        Console.WriteLine("Please enter the text of the verse: ");
        string verseText = Console.ReadLine();
        Scripture scripture = new Scripture(verseText);
        string reference = scripture.GetReferenceFromUser(book, chapter, verse, endVerse);
        Console.Clear();
        Console.WriteLine(reference);
        scripture.DisplayVerse();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        while (Console.ReadLine() != "quit")
        {
            Console.Clear();
            scripture.HideWord();
            scripture.DisplayHiddenVerse();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        }
    }
}