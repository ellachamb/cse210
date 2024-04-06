using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running("2024-04-03", 30, 5);
        activities.Add(running);
        Cycling cycling = new Cycling("2023-04-04", 60, 30);
        activities.Add(cycling);
        Swimming swimming = new Swimming("2024-04-05", 45, 100);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}