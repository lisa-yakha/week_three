//task: https://exercism.org/tracks/csharp/exercises/elons-toys/
using System;

class RemoteControlCar
{
    int metersDriven = 0;
    int batteryLeft = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (batteryLeft == 0)
            return "Battery empty";
        else
            return $"Battery at {batteryLeft}%";
    }

    public void Drive()
    {
        if (batteryLeft > 0)
        {
            metersDriven += 20;
            batteryLeft -= 1;
        }
    }
}