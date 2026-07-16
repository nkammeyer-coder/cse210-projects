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
        string[] words = text.Split(' ');
   
        foreach (string wordText in words)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
}