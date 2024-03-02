public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void ShowSpinner(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write("|");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("/");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("\\");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.WriteLine(" ");
        Console.WriteLine();
    }

    public void ShowCountdownTimer()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine(" ");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(1);
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName} Activity.");
        ShowSpinner(2);
    }

}