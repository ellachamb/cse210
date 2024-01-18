using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random(); 
        int magicNumber = randomGenerator.Next(1, 11); 

        int guess = -1; 

        do {
        Console.Write("What is your guess? "); 
        string userInput1 = Console.ReadLine(); 
        guess = int.Parse(userInput1);

        if (guess == magicNumber) 
        {
            Console.WriteLine("You guessed it!"); 
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher"); 
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower"); 
        }
        } while (guess != magicNumber); 
    }
}