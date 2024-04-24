//task: https://exercism.org/tracks/csharp/exercises/need-for-speed
using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int currentSpeed;
    private int currentBattery;
    public RemoteControlCar(int givenSpeed, int givenBatteryDrain)
    {
        speed = givenSpeed;
        batteryDrain = givenBatteryDrain;
        currentSpeed = 0;
        currentBattery = 100;
    }

    public bool BatteryDrained()
    {
        if (currentBattery >= batteryDrain)
            return false;
        else
            return true;
    }

    public int DistanceDriven()
    {
        return currentSpeed;
    }

    public void Drive()
    {
        if (currentBattery >= batteryDrain)
            currentSpeed = currentSpeed + speed;
        currentBattery = currentBattery - batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;
    public RaceTrack(int givenDistance)
    {
        distance = givenDistance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() && distance >= car.DistanceDriven())
            car.Drive();
        if (car.DistanceDriven() >= distance)
            return true;
        else
            return false;
    }
}