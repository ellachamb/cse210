public class Checklist : Goal
{
    private int _bonusTimes;
    private int _bonusPoints;

    private int _timesCompleted = 0;

    public void SetBonusTimes(int bonusTimes)
    {
        _bonusTimes = bonusTimes;
    }

    public int GetBonusTimes()
    {
        return _bonusTimes;
    }

    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"{GetName()} has been completed!");
        _timesCompleted++;
        if (_timesCompleted == _bonusTimes)
        {
            Console.WriteLine($"You have completed the goal {_bonusTimes} times! You have earned {_bonusPoints} bonus points!");
            SetComplete();
            return GetPoints() + _bonusPoints;
        }
        return GetPoints();
    }

    public override void Display()
    {
        Console.WriteLine($"[{IsComplete()}] {GetName()} ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_bonusTimes} times");
    }
}