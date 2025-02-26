using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShotgunData", menuName = "ScriptableObjects/ShotgunData", order = 1)]
public class ShotgunData : ScriptableObject
{
    public List<Shotgun> data;
}

[System.Serializable]
public class Shotgun : BaseStatsWeapon, IBullets
{
    public float Bullets { get; set; }
}