using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SniperData", menuName = "ScriptableObjects/SniperData", order = 1)]
public class SniperData : ScriptableObject
{
    public List<Sniper> sniperData;
    private void OnValidate()
    {
        foreach (Sniper sniper in sniperData)
        {
            sniper.TypeWeapon = TypeWeapon.Sniper;
        }
    }
}

[System.Serializable]
public class Sniper : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float AimTime;
}