using System;

class Program
{
    static void Main(string[] args)
    {
        Goal goal = new Goal();
        Console.Clear();
        Console.WriteLine($"You have {goal.GetTotalPoints()} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        while (choice != "6")
        {
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("   1. Simple Goal");
                    Console.WriteLine("   2. Eternal Goal");
                    Console.WriteLine("   3. Checklist Goal");
                    Console.Write("What type of goal would you like to create? (Please type a number): ");
                    string goalType = Console.ReadLine();
                    Console.Write("What is the name of your goal?: ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is the description of your goal?: ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with the goal?: ");
                    int goalPoints = Convert.ToInt32(Console.ReadLine());
                    switch (goalType)
                    {
                        case "1":
                            Simple simple = new Simple();
                            simple.SetName(goalName);
                            simple.SetDescription(goalDescription);
                            simple.SetPoints(goalPoints);
                            goal.AddGoal(simple);
                            break;
                        case "2":
                            Eternal eternal = new Eternal();
                            eternal.SetName(goalName);
                            eternal.SetDescription(goalDescription);
                            eternal.SetPoints(goalPoints);
                            goal.AddGoal(eternal);
                            break;
                        case "3":
                            Console.Write("How many times does this goal need to be completed for a bonus?: ");
                            int bonusTimes = Convert.ToInt32(Console.ReadLine());
                            Console.Write("What is the bonus amount of points for completing the goal?: ");
                            int bonusPoints = Convert.ToInt32(Console.ReadLine());
                            Checklist checklist = new Checklist();
                            checklist.SetName(goalName);
                            checklist.SetDescription(goalDescription);
                            checklist.SetPoints(goalPoints);
                            checklist.SetBonusTimes(bonusTimes);
                            checklist.SetBonusPoints(bonusPoints);
                            goal.AddGoal(checklist);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Your goals are: ");
                    goal.List();
                    break;
                case "3":
                    Console.Write("What is the filename of your goal file? ");
                    string fileName = Console.ReadLine();
                    goal.Save(fileName);
                    break;
                case "4":
                    Console.Write("What is the filename of your goal file? ");
                    string filename = Console.ReadLine();
                    goal.Load(filename);
                    break;
                case "5":
                    Console.WriteLine("The goals are:");
                    goal.List();
                    Console.Write("Which goal would you like to accomplish?: ");
                    string userInput = Console.ReadLine();
                    goal.RecordCompletion(userInput);
                    break;
                case "6":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"You have {goal.GetTotalPoints()} points.");
            string award = goal.SetAward();
            Console.WriteLine(award);
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();
        }

    }
}