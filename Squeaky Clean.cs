//https://exercism.org/tracks/csharp/exercises/squeaky-clean
using System;
using System.Text;

public static class Identifier
{
    private static bool IsGreekLowercase(char c) => (c >= 'α' && c <= 'ω');

    public static string Clean(string identifier)
    {
        StringBuilder stringBuilder = new StringBuilder();
        bool kebabCase = false;
        foreach(var c in identifier)
        {
            stringBuilder.Append(c switch
            { 
                _ when IsGreekLowercase(c) => default,
                _ when kebabCase => char.ToUpper(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => default,
            });
            kebabCase = c.Equals('-');
        }
        return stringBuilder.ToString();
    }

}