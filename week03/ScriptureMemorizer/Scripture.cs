using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide = 1)
    {
        List<int> showingIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsShowing())
            {
                showingIndices.Add(i);
            }
        }

        if (showingIndices.Count == 0) return;

        int countToHide = numberToHide;
        if (countToHide > showingIndices.Count)
        {
            countToHide = showingIndices.Count;
        }

        Random random = new Random();

        for (int i = 0; i < countToHide; i++)
        {
            int randomIndex = random.Next(showingIndices.Count);
            int wordIndexToHide = showingIndices[randomIndex];

            _words[wordIndexToHide].Hide();
            showingIndices.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayString()
    {
        string display = _reference.GetDisplayString() + "\n";
        
        foreach (Word word in _words)
        {
            display += word.GetDisplayString() + " ";
        }
        
        return display;
    }

    public bool AreAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsShowing())
            {
                return false;
            }
        }
        return true;
    }
}