//Task: https://exercism.org/tracks/csharp/exercises/acronym
using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string result = "";
        for (int i = 0; i < phrase.Length; i++)
        {
            if (char.IsLetter(phrase[i]) && ((i == 0) || (phrase[i-1] == ' ') || phrase[i-1] == '-') || phrase[i-1] == '_')
            {
                if (phrase[i] == ' ')
                    i++;
                result += char.ToUpper(phrase[i]);
            }
        }
        return  result;
    }
    
}