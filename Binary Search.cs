//https://exercism.org/tracks/csharp/exercises/binary-search/
using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        if (input.Length == 0)
            return -1;
        if (value == input[0])
            return 0;
        Array.Sort(input);
        int middle = (int)(input.Length / 2);
        if (middle == 0)
            return -1;
        if (value == input[middle])
            return middle;
        if (value < input[middle])
        {
            while (middle > 0)
            {
                if (value == input[middle])
                    return middle;
                middle--;
            }
        }
        if (value > input[middle])
        {
            while (middle < input.Length)
            {
                if (value == input[middle])
                    return middle;
                middle++;
            }
        }
    return -1;        
    }
}
