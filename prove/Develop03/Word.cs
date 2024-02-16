using System;
public class Word
{
    private string _word;
    private bool _visible = true;

    public Word(string userText)
    {
        _word = userText;
    }
    public string GetWordText()
    {
        return _word;
    }
    public void SetVisibility(bool visible)
    {
        _visible = visible;
    }
    public bool GetVisibility()
    {
        return _visible;
    }
    public bool HideWord()
    {
        return _visible = false;
    }


}