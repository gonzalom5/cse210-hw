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
        int wordsHidden = 0;

        while (wordsHidden < count)
        {
            List<Word> shownWords = new List<Word>();
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    shownWords.Add(word);
                }
            }
            if (shownWords.Count == 0)
            {
                break;
            }
            int randomIndex = _random.Next(shownWords.Count);
            Word selectedWord = shownWords[randomIndex];
            selectedWord.Hide();
            wordsHidden++;
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

