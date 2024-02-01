using System;

public class PromptGenerator
{
    public string[] _prompts = new string[]
    {
        "What was the best part of your day?",
        "What was the most challenging part of your day?",
        "What was the strongest emotion you felt today?",
        "How did you see the hand of the Lord in your life?",
        "If you had one thing you could do over today, what would it be?",
        "What was the best person you interacted with today?",
        "What goals do you want to make for tomorrow?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }

    // public static void Display()
    // {
    //     Console.WriteLine($"Prompt: {_randomPrompt}");
    // }

}