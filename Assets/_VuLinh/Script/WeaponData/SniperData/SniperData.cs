using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SniperData", menuName = "ScriptableObjects/SniperData", order = 1)]
public class SniperData : ScriptableObject
{
    public List<Sniper> data;
}

[System.Serializable]
public class Sniper : BaseStatsWeapon, IAimTime
{
    public float AimTime { get; set; }
}