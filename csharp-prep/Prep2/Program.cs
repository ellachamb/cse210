using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?" ); 
        string userInput = Console.ReadLine(); 
        int gradePercent = int.Parse(userInput);
        string letter; 

        if (gradePercent >= 90)
        {
            letter = "A"; 
        }
        else if (gradePercent >= 80)
        {
            letter = "B"; 
        }
        else if (gradePercent >= 70)
        {
            letter = "C"; 
        }
        else if (gradePercent >= 60)
        {
            letter = "D"; 
        }
        else if (gradePercent < 60) 
        {
            letter = "F"; 
        }
        else
        {
            letter = "N/A"; 
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercent >= 70) 
        {
            Console.WriteLine("You passed the course!"); 
        }
        else if (gradePercent < 70) 
        {
            Console.WriteLine("You have not passed the course."); 
        }
        else 
        {
            Console.WriteLine("N/A"); 
        }
    }
}