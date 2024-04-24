//https://exercism.org/tracks/csharp/exercises/bird-watcher
using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeek;
        //throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        return birdsPerDay[6];
        //throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[6]++;
        //throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        for(int i = 0; i < 6; i++)
        {
            if (birdsPerDay[i] == 0)
                return true;
        }
    return false;
        //throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int res = 0;
        for (int i = 0; i < numberOfDays; i++)
            res += birdsPerDay[i];
        return res;
            
    }

    public int BusyDays()
    {
        int res = 0;
        for (int i = 0; i < 6; i++)
        {
            if (birdsPerDay[i] >= 5)
                res++;
        }
    return res;
        //throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
        
    }
}