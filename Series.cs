//https://exercism.org/tracks/csharp/exercises
using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if ((sliceLength > numbers.Length) || (numbers == null) || (numbers == "") || (sliceLength <= 0))
            throw new ArgumentException("Invalid input");
        string[] res = new string[numbers.Length - sliceLength + 1];
        for (int i = 0; (i <= numbers.Length - sliceLength); i++)
            res[i] = numbers.Substring(i,sliceLength);
    return res;
    }

}