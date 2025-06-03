using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] splitVerse = text.Split(' ');

        foreach (string wordText in splitVerse)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int count = 3)
    {
        for (int i = 0; i < count; i++)
        {
            int attempts = 0;
            bool wordHidden = false;

            while (!wordHidden && attempts < 100)
            {
                int index = _random.Next(_words.Count);
                Word selectedWord = _words[index];

                if (!selectedWord.IsHidden())
                {
                    selectedWord.Hide();
                    wordHidden = true;
                }
                attempts++;
            }
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetRenderedText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            result += word.GetRenderedText() + " ";
        }
        return result.Trim();
    }

}

