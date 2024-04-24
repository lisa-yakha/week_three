//https://exercism.org/tracks/csharp/exercises/roll-the-die
using System;

public class Player
{
    Random num = new Random();
    public int RollDie()
    {
        return num.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        return num.NextDouble() * 99.9;
    }
}