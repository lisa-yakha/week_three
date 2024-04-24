//Task: exercism.org/tracks/csharp/exercises/isogram

using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        int count = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsLetter(word[i]))
            {
                count = word.Count(x => x == word[i]);
                if (count > 1)
                    return false;
             }
            count = 0; 
        }
         return true;
    }
}