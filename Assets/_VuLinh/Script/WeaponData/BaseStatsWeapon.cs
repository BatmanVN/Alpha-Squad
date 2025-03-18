using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RarityWeapon
{
    Common,
    Uncommon,
    Exceptional,
    Rare,
    Epic,
    Legendary
}
public enum TypeWeapon
{
    Pistol,
    SMG,
    Shotgun,
    Rifle,
    Sniper,
    Bomb
}

public class BaseStatsWeapon
{
    [HorizontalGroup("Split", 75)]
    [HideLabel]
    [PreviewField(75)]
    [VerticalGroup("Split/Left")]
    public Sprite sprite;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public string NameGun;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public RarityWeapon Rarity;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public TypeWeapon TypeWeapon;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Damage;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float FireRate;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Range;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float CritChance;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float CritDame;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Ammo;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Cooldown;

    //[VerticalGroup("Split/Right")]
    //[LabelWidth(100)]
    //public GameObject prefab;
}
