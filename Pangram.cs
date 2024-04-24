//Task: https://exercism.org/tracks/csharp/exercises/pangram

using System;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;
        input = input.ToLower();
        string lower = "abcdefghijklmnopqrstuvwxyz";
        foreach (char letter in lower)
        {
            if (char.IsLetter(letter))
            {
                if(!(input.Contains(letter)))
                {
                    return false; 
                }
                   
            }
        }
        return true;
    }
}

/*public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (input == null || input == "")
            return false;
        string lower = "abcdefghijklmnopqrstuvwxyz";
        string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int count = 0;
        for (int i = 0; i < lower.Length; i++)
        {
            if(input.Contains(lower[i]))
               count ++;
        }
        for (int i = 0; i < upper.Length; i++)
        {
            if(input.Contains(upper[i]))
                count++;
        }
        if (count == 26)
            return true;
        return false;
    }
}*/