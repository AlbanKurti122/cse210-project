using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text string by spaces and populate the list of Word objects
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Stretch Challenge: Filter to find indices of words that are NOT already hidden
        List<int> visibleIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }

        // Determine how many words we can actually hide
        int actualToHide = Math.Min(numberToHide, visibleIndices.Count);

        // Randomly pick from only the visible options
        for (int i = 0; i < actualToHide; i++)
        {
            int randomIndex = random.Next(visibleIndices.Count);
            int wordIndexToHide = visibleIndices[randomIndex];
            
            _words[wordIndexToHide].Hide();
            
            // Remove from our temporary tracker so we don't pick it twice in the same turn
            visibleIndices.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string joinedText = string.Join(" ", displayWords);
        return $"{_reference.GetDisplayText()} - {joinedText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // Found a word that is still visible
            }
        }
        return true; // All words are hidden
    }
}