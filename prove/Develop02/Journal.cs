using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public string GetFileName()
    {
        Console.WriteLine("Enter file name: ");
        string _filename = Console.ReadLine();
        string _file = ($"{_filename}.txt");
        return _file;
    }


}