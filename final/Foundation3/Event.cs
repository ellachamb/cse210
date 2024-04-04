public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;

    private string _address;

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public void SetAddress(Address address)
    {
        _address = address.GetAddress();
    }

    public void DisplayStandard()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Time: " + _time);
        Console.WriteLine("Address: " + _address);
    }

    public void DisplayShort()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Date: " + _date);
    }

    public void DisplayFull()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Time: " + _time);
        Console.WriteLine("Address: " + _address);
    }

}
