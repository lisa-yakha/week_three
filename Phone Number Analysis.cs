//task:https://exercism.org/tracks/csharp/exercises/phone-number-analysis
//first iteration:
using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        (bool IsNewYork, bool IsFake, string LocalNumber) res = (false, false, $"{phoneNumber.Split("-")[2]}");
        if (phoneNumber.Split("-")[0] == "212")
            res.IsNewYork = true;
        if (phoneNumber.Split("-")[1] == "555")
            res.IsFake = true;
        return res;

        //throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        if (phoneNumberInfo.IsFake == true)
            return true;
        else
            return false;
    }
}
//second iteration
using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] phoneNumberSplit = phoneNumber.Split('-');
        return (phoneNumberSplit[0] == "212", phoneNumberSplit[1] == "555", phoneNumberSplit[2]);
    }
    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}

