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
        "What is one lesson you learned today?",
        "How was your day better today than it was yesterday?",
        "Write a letter to your future self.",
        "What is one new hobby you want to learn?",
        "What is a song that represented the day you had today?",
        "What is one relationship in your life you want to strengthen?",
        "What is one act of kindness you witnessed today?",
        "What is one thing that made you laugh today?",
        "What is soemthing you are grateful for today?",
        "How are you going to make tomorrow a better day?",
        "What is a challenge you are currently facing?",
        "What is one habit you want to start?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }

}