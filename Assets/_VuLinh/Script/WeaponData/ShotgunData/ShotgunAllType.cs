using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ShotgunType
{
    LaserShotgun,
    PumpShotgun,
    DoubleBarrel,
    R9,
    Gallo,
    NinjaShotgun
}

[CreateAssetMenu(fileName = "ShotgunAllType", menuName = "ListGuns/ShotgunAllType", order = 1)]
public class ShotgunAllType : ScriptableObject
{
    public List<ShotgunTypeData> Shotgunstype;
}

[System.Serializable]
public class ShotgunTypeData
{
    public ShotgunType TypeShotgun;

    public ScriptableObject ShotgunTypeSOT;
}