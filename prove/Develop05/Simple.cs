public class Simple : Goal
{
    public override int RecordEvent()
    {
        SetComplete();
        Console.WriteLine($"{GetName()} has been completed!");
        return GetPoints();
    }

}
