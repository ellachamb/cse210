public class Swimming : Activity
{
    public int _laps;
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / GetLength() * 60, 2);
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

}