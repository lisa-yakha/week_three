//task: https://exercism.org/tracks/csharp/exercises/log-analysis
using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        return str.Substring(str.IndexOf(delimiter) + delimiter.Length);
    }

    public static string SubstringBetween(this string str, string delimiter1, string delimiter2)
    {
        string newstr = str.Substring(str.IndexOf(delimiter1) + delimiter1.Length);
        return newstr.Substring(0, newstr.IndexOf(delimiter2));
    }

    public static string Message(this string str)
    {
        return str.Substring(str.IndexOf(": ") + 2);
    }

    public static string LogLevel(this string str)
    {
        return str.Substring(str.IndexOf("[") + 1, str.IndexOf("]") - 1);
    }
}