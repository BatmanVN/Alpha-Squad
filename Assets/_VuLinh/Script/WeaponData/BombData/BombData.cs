using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BombData", menuName = "ScriptableObjects/BombData", order = 1)]
public class BombData : ScriptableObject
{
    public List<Bomb> bombData;
    private void OnValidate()
    {
        foreach (Bomb bomb in bombData)
        {
            bomb.TypeWeapon = TypeWeapon.Bomb;
        }
    }
}

[System.Serializable]
public class Bomb : BaseStatsWeapon
{
    public float DameOverTime;
    public float ExplosiveRadius;
}