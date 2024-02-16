using System;
public class Scripture
{
    private List<Word> _words = new List<Word>();
    public Scripture(string userText)
    {
        string[] words = userText.Split(' ');
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void DisplayVerse()
    {
        string verse = "";
        foreach (Word word in _words)
        {
            verse += word.GetWordText() + " ";
        }
        Console.WriteLine(verse);
    }
    public void HideWord()
    {
        for (int i = 0; i < _words.Count / 5; i++)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            _words[index].HideWord();
        }

    }

    public void DisplayHiddenVerse()
    {
        string verse = "";
        foreach (Word word in _words)
        {
            if (word.GetVisibility())
            {
                verse += word.GetWordText() + " ";
            }
            else
            {
                string hiddenWord = "";
                string originalWord = word.GetWordText();
                foreach (char c in originalWord)
                {
                    hiddenWord += "_";
                }
                verse += hiddenWord + " ";
            }
        }
        Console.WriteLine(verse);
    }
    public string GetReferenceFromUser(string book, string chapter, string verse, string endVerse)
    {
        if (endVerse == "N/A")
        {
            Reference reference = new Reference(book, chapter, verse);
            string getReference = reference.GetReference1();
            return getReference;
        }
        else
        {
            Reference reference = new Reference(book, chapter, verse, endVerse);
            string getReference = reference.GetReference2();
            return getReference;
        }
    }

}