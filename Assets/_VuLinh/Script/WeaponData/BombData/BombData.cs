using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BombData", menuName = "ScriptableObjects/BombData", order = 1)]
public class BombData : ScriptableObject
{
    public List<Sniper> data;
}

[System.Serializable]
public class Bomb : BaseStatsWeapon, IBombStats
{
    public float DameOverTime { get; set; }
    public float ExplosiveRadius { get; set; }
}