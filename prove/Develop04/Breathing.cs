public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your head and focus on your breathing.")
    {
    }

    public void DisplayBreathingIntervals(int duration)
    {

        for (int i = duration / 8; i > 0; i--)
        {
            Console.Write("Inhale...");
            ShowCountdownTimer();
            Console.Write("Exhale...");
            ShowCountdownTimer();
            Console.WriteLine();
        }
    }
}