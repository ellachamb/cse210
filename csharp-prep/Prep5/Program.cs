using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage(); 
        string userName = PromptUserName(); 
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber); 

        DisplayResult(userName, squaredNumber);

        static void DisplayWelcomeMessage() 
        {
            Console.WriteLine("Welcome to the Program!"); 
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: "); 
            string userName = Console.ReadLine(); 
            return userName; 
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: "); 
            int userNumber = int.Parse(Console.ReadLine()); 
    
            return userNumber; 
        }
        static int SquareNumber(int userNumber)
        {
            int squaredNumber = userNumber * userNumber; 
            return squaredNumber; 
        }
        static void DisplayResult(string name, int square)
        {
        Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}