//Task https://exercism.org/tracks/csharp/exercises/high-school-sweethearts
using System;
using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        return $"                  {studentA} ♡ {studentB}                    ";
    }

    public static string DisplayBanner(string studentA, string studentB)
    {
        return $@"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {studentA.Trim()}  +  {studentB.Trim()}     **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
        ";
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        return $"{studentA} and {studentB} have been dating since {start.Date.ToString("dd.MM.yyyy")} - that's {hours.ToString("n2", CultureInfo.CreateSpecificCulture("de-DE"))} hours";
    }
}