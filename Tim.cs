//task: https://exercism.org/tracks/csharp/exercises/tim-from-marketing
using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (department == null)
            department = "owner";
        if (id == null)
            return $"{name} - {department.ToUpper()}";
        else
            return $"[{id}] - {name} - {department.ToUpper()}";
    }
}