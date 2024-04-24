//https://exercism.org/tracks/csharp/exercises/triangle
using System;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if ((IsTriangle(side1, side2, side3) == true) && (!(side1 == side2)) && (!(side2 == side3)) && (!(side3 == side1)))
            return true;
        return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (IsTriangle(side1, side2, side3) == true && ((IsEquilateral(side1, side2, side3) == true || ((side1 == side2) || (side1 == side3) || (side2 == side3)))))
                return true;
        return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if (IsTriangle(side1, side2, side3) == true && (side1 == side2 && side2 == side3))
            return true;
        return false;
    }

    public static bool IsTriangle(double side1, double side2, double side3)
    {
        if ((side1 > 0 || side2 > 0 || side3 > 0) && (side1 + side2 >= side3) && (side2 + side3 >= side1) && (side1 + side3 >= side2))
            return true;
        return false;
    }
}