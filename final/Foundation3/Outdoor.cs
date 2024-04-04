public class Outdoor : Event
{
    private string _speaker;
    private string _capacity;

    public Outdoor(string title, string description, string date, string time, string speaker, string capacity) : base(title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplaySpeakerAndCapacity()
    {
        Console.WriteLine("Speaker: " + _speaker);
        Console.WriteLine("Capacity: " + _capacity);
    }

}