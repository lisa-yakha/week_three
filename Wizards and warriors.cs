//https://exercism.org/tracks/csharp/exercises/wizards-and-warriors/
using System;

abstract class Character
{
    string character;
    protected Character(string characterType)
    {
        character = characterType;
        
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
            return false;
    }

    public override string ToString()
    {
        return $"Character is a {character}";
    }
}

class Warrior : Character
{

    
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable() == true)
            return 10;
        else 
            return 6; 
    }
}

class Wizard : Character
{
    bool spellPrepared = false;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (spellPrepared == true)
            return 12;
        else
            return 3;
    }

    public void PrepareSpell()
    {    
        spellPrepared = true;
    }
    public override bool Vulnerable()
    {
        if (!spellPrepared)
            return true;
        else
            return false;
    }
}
