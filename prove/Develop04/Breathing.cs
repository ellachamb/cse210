public class Breathing : Activity
{
    private int _breathingCount = 0;
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your head and focus on your breathing.")
    {
    }

    public void DisplayBreathingIntervals(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Inhale...");
            ShowCountdownTimer();
            Console.Write("Exhale...");
            ShowCountdownTimer();
            Console.WriteLine();
        }
        _breathingCount++;
    }

    public int GetBreathingCount()
    {
        return _breathingCount;
    }
}