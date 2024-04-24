//https://exercism.org/tracks/csharp/exercises/booking-up-for-beauty
using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if (DateTime.Compare(appointmentDate, DateTime.Now) <0)
            return true;
        return false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
       
        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
            return true;
        return false;
 
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString()}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(2024, 9, 15, 0, 0, 0);
    }
}