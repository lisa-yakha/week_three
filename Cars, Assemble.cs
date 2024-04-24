//task:https://exercism.org/tracks/csharp/exercises/cars-assemble
using System;

static class AssemblyLine
{
	public static double SuccessRate(int speed)
	{
		double res;
		if (speed == 0)
			res = 0;
		else if (speed <= 4)
			res = 1.00;
		else if (speed <= 8)
			res = 0.90;
		else if (speed == 9)
			res = 0.80;
		else
			res = 0.77;
		return res;
	}

	public static double ProductionRatePerHour(int speed)
	{
		return speed * 221 * SuccessRate(speed);
	}

	public static int WorkingItemsPerMinute(int speed)
	{
		return (int)ProductionRatePerHour(speed) / 60;
	}
}