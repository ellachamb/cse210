using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string NameFile()
    {
        Console.WriteLine("Enter file name (please add .txt to the end): ");
        string _fileName = Console.ReadLine();
        return _fileName;
    }
    public void SaveFile(string filename, List<Entry> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry singleEntry in entries)
            {
                outputFile.WriteLine($"{singleEntry._entryDate}");
                outputFile.WriteLine($"{singleEntry._prompt}");
                outputFile.WriteLine($"{singleEntry._response}");
            }
            Console.WriteLine($"Saved file to {filename}");
        }
    }

    public void LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }

}