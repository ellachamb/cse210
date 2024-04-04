using System;

class Program
{
    static void Main(string[] args)
    {
        Reception event1 = new Reception("Reception Event", "Reception Event Description", "2021-12-03", "14:00", "reception@email.com");
        event1.SetAddress(new Address("123 Main St", "Springfield", "IL", "62701"));
        Outdoor event2 = new Outdoor("Outdoor Event", "Outdoor Event Description", "2021-12-04", "15:00", "John Doe", "900");
        event2.SetAddress(new Address("456 Elm St", "Springfield", "IL", "62702"));
        Lectures event3 = new Lectures("Lectures Event", "Lectures Event Description", "2021-12-05", "16:00", "Sunny");
        event3.SetAddress(new Address("789 Oak St", "Springfield", "IL", "62703"));

        event1.DisplayStandard();
        Console.WriteLine();
        event1.DisplayShort();
        Console.WriteLine();
        event1.DisplayFull();
        event1.DisplayEmail();
        Console.WriteLine();

        event2.DisplayStandard();
        Console.WriteLine();
        event2.DisplayShort();
        Console.WriteLine();
        event2.DisplayFull();
        event2.DisplaySpeakerAndCapacity();
        Console.WriteLine();

        event3.DisplayStandard();
        Console.WriteLine();
        event3.DisplayShort();
        Console.WriteLine();
        event3.DisplayFull();
        event3.DisplayWeather();
    }
}