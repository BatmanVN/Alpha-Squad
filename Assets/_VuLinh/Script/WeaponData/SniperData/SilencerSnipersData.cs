using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SilencerSnipersData", menuName = "SniperTypeOST/SilencerSnipersData", order = 6)]

public class SilencerSnipersData : ScriptableObject
{
    public List<SilencerSniperData> SilencerSniperList = new();
    private void OnValidate()
    {
        foreach (var data in SilencerSniperList)
        {
            data.TypeWeapon = TypeWeapon.Sniper;
            data.AimTime = 0.9f;
            data.FireRate = 52f;
            data.Range = 30f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 4;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class SilencerSniperData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float AimTime;
}
