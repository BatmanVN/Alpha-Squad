using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScifiSnipersData", menuName = "SniperTypeOST/ScifiSnipersData", order = 6)]

public class ScifiSnipersData : ScriptableObject
{
    public List<ScifiSniperData> ScifiSniperList = new();
    private void OnValidate()
    {
        foreach (var data in ScifiSniperList)
        {
            data.TypeWeapon = TypeWeapon.Sniper;
            data.AimTime = 0.9f;
            data.FireRate = 60f;
            data.Range = 28f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 3;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class ScifiSniperData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float AimTime;
}
