public class Lectures : Event
{
    private string _weather;

    public Lectures(string title, string description, string date, string time, string weather) : base(title, description, date, time)
    {
        _weather = weather;
    }

    public void DisplayWeather()
    {
        Console.WriteLine("Weather: " + _weather);
    }

}