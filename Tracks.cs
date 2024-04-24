//https://exercism.org/tracks/csharp/exercises/tracks-on-tracks-on-tracks/
using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> listOfLanguages = new List<string>();
        listOfLanguages.Add("C#");
        listOfLanguages.Add("Clojure");
        listOfLanguages.Add("Elm");
        return listOfLanguages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        int res = 0;
        foreach (string i in languages)
            res++;
        return res;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        int position = languages.IndexOf(language);
        if (position > 0)
            return true;
        return false;

    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (CountLanguages(languages) > 0)
        {
          if (languages[0] == "C#")
            return true;
        if (languages[1] == "C#" && (CountLanguages(languages) == 2 || CountLanguages(languages) == 3 ))
            return true;  
        }
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        int i = 0;
        while (i < CountLanguages(languages))
        {
            int j = 0;
            int count = 0;
            while (j < CountLanguages(languages))
            {
                if (languages[i] == languages[j])
                    {
                        count ++;
                        if (count == 2)
                            return false;
                    }
                    j++;
            }
            i++;
        }
        return true;
    }
}