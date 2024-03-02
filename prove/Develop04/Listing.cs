public class Listing : Activity
{
    private int _listingCount = 0;
    private List<string> _prompts = new List<string>()
    {
        "What are you grateful for?",
        "What are you proud of?",
        "What are you looking forward to?",
        "What do you love about yourself?",
        "What do you love about your life?",
        "What do you love about your family?",
        "What do you love about your friends?",
        "What are things you want to improve in your life?",
        "What are good things that happened today?",
        "What are things you want to do in the future?",
        "What are things you want to do in the next year?",
        "How have you been blessed in your life?",
        "What are some habits you wish you had or want to improve?",
        "What are some things you want to learn?",
    };

    private List<string> _responses = new List<string>();

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life and help you focus on the positive.")
    {
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayPrompts(int duration)
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine("--- " + GetRandomPrompt() + " ---");
        Console.WriteLine("You may begin in: ");
        ShowCountdownTimer();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            _responses.Add(input);
        }
        Console.WriteLine($"You listed {_responses.Count} responses!");
        _listingCount++;
    }

    public int GetListingCount()
    {
        return _listingCount;
    }

}