//Task: https://exercism.org/tracks/csharp/exercises/anagram/
using System;
using System.Linq;
using System.Collections.Generic;

public class Anagram
{
    string baseWord;
    
    public Anagram(string baseWord)
    {
        this.baseWord = baseWord;    
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> matches = new List<string>();        
        foreach (string word in potentialMatches)
        {
            if(IsAnagram(word))
                matches.Add(word);
        }
        return matches.ToArray();
    }

    bool IsAnagram(string word)
    {
        if (!baseWord.Equals(word, StringComparison.OrdinalIgnoreCase) && LetterSetCheck(word).Equals(LetterSetCheck(baseWord)))
            return true;
    return false;
    }

    public string LetterSetCheck(string word)
    {
        return String.Concat(word.ToLower().OrderBy(letter => letter));
    }

}