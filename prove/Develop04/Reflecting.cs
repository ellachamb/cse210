public class Reflecting : Activity
{
    private int _reflectingCount = 0;
    private List<int> _usedIndices = new List<int>();
    private List<string> _reflectionPrompts = new List<string>()
    {
        "Reflect on a time when you faced a challenge and overcame it.",
        "Reflect on a time when you stood up for someone.",
        "Think about a mistake you made in the past.",
        "Recall a time when you did something really difficult.",
        "Reflect on a time when you felt overwhelmed and overcame it.",
        "Think about a time when you felt like giving up but kept going.",
        "Think about a significant change or transition you experienced in the past.",
        "Consider a a time when you accoomplished a goal or aspiration.",
        "Reflect on a time when you helped someone else.",
        "Think of a time when you did something trully selfless",
    };
    private List<string> _questions = new List<string>(){
        "What did you learn from this experience?",
        "Why was this experience meaningful to you?",
        "How did you feel during this experience?",
        "What strengths did you demonstrate during this experience?",
        "What did you learn about yourself from this experience?",
        "How did this experience shape you?",
        "What will you do in the future from this experience?",
        "Do you have any regrets about the experience?",
        "What was your favorite thing about this experience?",
        "Do you feel differently about this experience now then you did when it happened?",
        "How did you feel when it was complete?",
    };
    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ")
    {
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_reflectionPrompts.Count);
        return _reflectionPrompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index;

        do
        {
            index = random.Next(_questions.Count);
        } while (_usedIndices.Contains(index));

        _usedIndices.Add(index);
        return _questions[index];
    }

    public void DisplayPrompts(string prompt, int duration)
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("--- " + prompt + " ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdownTimer();
        Console.Clear();
        for (int i = duration / 10; i > 0; i--)
        {
            Console.Write("> " + GetRandomQuestion());
            ShowSpinner(5);
        }
        _usedIndices.Clear();
        _reflectingCount++;
    }

    public int GetReflectingCount()
    {
        return _reflectingCount;
    }
}