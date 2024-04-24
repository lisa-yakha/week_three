//https://exercism.org/tracks/csharp/exercises/football-match-reports
using System;


public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch(shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3: case 4:
                return "center back";
            case 5:
                return "right back";
            case 6: case 7: case 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                    throw new ArgumentOutOfRangeException("Wrong number");  
        }
        }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int:
                return $"There are {report} supporters at the match.";
            case string:
                return $"{report}";
            case Incident i and not Injury:
                 return i.GetDescription();
            case Incident j and Injury:
                return $"Oh no! {j.GetDescription()} Medics are on the field.";
            case Manager {Club: null} m:
                return $"{m.Name}";
            case Manager m:
                return $"{m.Name} ({m.Club})";
            default:
                    throw new ArgumentException("Wrong input");
        }
    }
}






public class Manager
{
    public string Name { get; }

    public string? Club { get; }

    public Manager(string name, string? club)
    {
        this.Name = name;
        this.Club = club;
    }
}

public class Incident
{
    public virtual string GetDescription() => "An incident happened.";
}

public class Foul : Incident
{
    public override string GetDescription() => "The referee deemed a foul.";
}

public class Injury : Incident
{
    private readonly int player;

    public Injury(int player)
    {
        this.player = player;
    }

    public override string GetDescription() => $"Player {player} is injured.";
}