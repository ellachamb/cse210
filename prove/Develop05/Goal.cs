using System;
using System.IO;
public class Goal
{
    private string _name;
    private string _description;
    private int _points;

    private string _isComplete = " ";

    private int _totalPoints = 0;

    private List<Goal> _goals = new List<Goal>();

    public string IsComplete()
    {
        return _isComplete;
    }

    public virtual void SetComplete()
    {
        _isComplete = "X";
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine(goal.GetName() + " has been added.");
    }

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.Write($"Name: {goal.GetName()} ");
                outputFile.Write($"Description: {goal.GetDescription()} ");
                outputFile.Write($"Points: {goal.GetPoints()} ");
                outputFile.WriteLine($"Completion: {goal.IsComplete()} ");
            }
            Console.WriteLine($"Saved file to {fileName}");
        }
    }
    public void Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    public void List()
    {
        int num = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{num}. ");
            goal.Display();
            num++;
        }
    }

    public virtual void Display()
    {
        Console.WriteLine($"[{IsComplete()}] {GetName()} ({GetDescription()})");
    }

    public void RecordCompletion(string userInput)
    {
        int num = 1;
        foreach (Goal goal in _goals)
        {
            if (userInput == num.ToString())
            {
                _totalPoints += goal.RecordEvent();
                Console.WriteLine("You have earned " + goal.GetPoints() + " points for a total of " + _totalPoints + " points!");
            }
            num++;
        }
    }

    public virtual int RecordEvent()
    {
        Console.WriteLine($"{GetName()} has been completed!");
        return GetPoints();
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public List<Goal> GetGoal()
    {
        return _goals;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public string SetAward()
    {
        if (_totalPoints >= 100)
        {
            return "You have earned the bronze award!";
        }
        else if (_totalPoints >= 200)
        {
            return "You have earned the silver award!";
        }
        else if (_totalPoints >= 300)
        {
            return "You have earned the gold award!";
        }
        else
        {
            return "You have not earned an award yet.";
        }
    }
}