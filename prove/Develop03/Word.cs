using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    //Constructor that receives the word text and words are not hidden
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Constructor to hide words
    public void Hide()
    {
        _isHidden = true;
    }

    //Constructor that checks if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetRenderedText()
    {
        if (_isHidden)
        {
            string hiddenText = "";
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenText += "_";
            }
            return hiddenText;
        }
        else
        {
            return _text;
        }
    }
}
