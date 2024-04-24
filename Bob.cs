//https://exercism.org/tracks/csharp/exercises/bob
using System;
using System.Linq;

public static class Bob
{

    public static string Response(string statement)
    {
       bool allCaps = false;
        
        if (string.IsNullOrEmpty(statement) == true || string.IsNullOrWhiteSpace(statement) == true)
           return "Fine. Be that way!";
        
        if (statement.Any(char.IsLetter))
            {
                  for(int i =0; i < statement.Length; i++)
        {
            if (Char.IsLetter(statement[i]) && !Char.IsUpper(statement[i]))
            {
                allCaps = false;
                break;
            } 
            allCaps = true;
        }
            }
             
        if (statement.Trim()[statement.Trim().Length - 1] == '?')
       {
           if (allCaps == true)
               return "Calm down, I know what I'm doing!";
            else
                return "Sure.";
       }
    else if (allCaps == true)
        return "Whoa, chill out!";
    else 
        return "Whatever.";

    }

}