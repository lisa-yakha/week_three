//https://exercism.org/tracks/csharp/exercises/protein-translation
using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<string> proteins = new List<string>();
        var end = 3;
        while (end <= strand.Length)
        {
            string strandSplit = strand.Substring(end-3, 3);
            string toProtein = ToProtein(strandSplit);
            switch(toProtein)
            {
                case "STOP":
                    return proteins.ToArray();
                default:
                    proteins.Add(toProtein);
                    break;
            }
        end += 3;
        }
        return proteins.ToArray();
    }

    private static string ToProtein(string input) =>
        input switch
        {
            "AUG" => "Methionine",
            "UUU" => "Phenylalanine",
            "UUC" => "Phenylalanine",
            "UUA" => "Leucine",
            "UUG" => "Leucine",
            "UCU" => "Serine",
            "UCC" => "Serine",
            "UCA" => "Serine",
            "UCG" => "Serine",
            "UAU" => "Tyrosine",
            "UAC" => "Tyrosine",
            "UGU" => "Cysteine",
            "UGC" => "Cysteine",
            "UGG" => "Tryptophan",
            "UAA" => "STOP",
            "UAG" => "STOP",
            "UGA" => "STOP",
            _ => throw new Exception("Invalid sequence")
        };
}