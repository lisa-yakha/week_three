//https://exercism.org/tracks/csharp/exercises/reverse-string
using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
        return new string(inputArray);
    }
}