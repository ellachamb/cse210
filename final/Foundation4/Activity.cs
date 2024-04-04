public class Activity
{
    private double _distance;
    private double _speed;
    private double _pace;
    private string _date;
    private int _length;

    public Activity(double distance, double speed, double pace, string date, int length)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
        _date = date;
        _length = length;
    }
    public virtual double GetDistance()
    {
        return _distance;
    }
}