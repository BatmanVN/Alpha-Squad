using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public int Id;

    public string Name;

    public SpecialSkill specialSkill;

    public Dictionary<int, StatsCharacter> Stats;
}
public class StatsCharacter{
    public float Health;
    public float Damege;

    public float RequiredCard;

    public float Money;
}
public enum SpecialSkill{
    SpeedAttack,

}


