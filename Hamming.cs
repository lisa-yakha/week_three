//https://exercism.org/tracks/csharp/exercises/hamming
using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (!(firstStrand.Length - secondStrand.Length == 0))
            throw new ArgumentException("Different lengths not suitable for method");
        int res = 0;
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (!(firstStrand[i] == secondStrand[i]))
                res++;
        }
    return res;
    }
}