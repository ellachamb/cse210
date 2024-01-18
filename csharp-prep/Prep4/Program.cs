using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter number: "); 
        string userInput = Console.ReadLine(); 
        int userNumber = int.Parse(userInput); 
        List<int> numbers = new List<int>(); 
        
        while (userNumber != 0)
        {
            numbers.Add(userNumber); 
            Console.Write("Enter number: "); 
            userInput = Console.ReadLine(); 
            userNumber = int.Parse(userInput); 
        }

        int sum = 0; 
        foreach (int number in numbers) {
            sum += number; 
        }
        Console.WriteLine($"The sum is: {sum}"); 

        float average = ((float)sum) / numbers.Count; 
        Console.WriteLine($"The average is: {average}"); 

        int largest = 0; 
        foreach (int number in numbers) {
            if (number > largest) {
                largest = number; 
            }
        }
        Console.WriteLine($"The largest number is: {largest}"); 
        
    }
}