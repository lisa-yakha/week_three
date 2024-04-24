//https://exercism.org/tracks/csharp/exercises/collatz-conjecture
using System;

public static class CollatzConjecture
{
    public static int Steps(int n)
    {
        int stepCounter = 0;
        int saveN = n;
        if (n <= 0)
            throw new ArgumentOutOfRangeException("Only positive numbers allowed");
        while (n > 1)
               {
                   if (n % 2 == 0)
                   {
                       n = n / 2;
                       stepCounter++;
                       if (n == 1)
                           break;
                   }
                   if (!(n % 2 == 0))
                   {
                       n = n *3 + 1;
                       stepCounter++;
                       if(n == 1)
                           break;
                   }
               }
               return stepCounter;
    }
}