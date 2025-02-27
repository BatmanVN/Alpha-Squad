using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShotgunData", menuName = "ScriptableObjects/ShotgunData", order = 1)]
public class ShotgunData : ScriptableObject
{
    public List<Shotgun> shotgunData;
    private void OnValidate()
    {
        foreach (Shotgun shotgun in shotgunData)
        {
            shotgun.TypeWeapon = TypeWeapon.Shotgun;
        }
    }
}

[System.Serializable]
public class Shotgun : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Bullets;
}