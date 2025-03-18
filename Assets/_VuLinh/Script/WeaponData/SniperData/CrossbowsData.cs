using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CrossbowsData", menuName = "SniperTypeOST/CrossbowsData", order = 6)]

public class CrossbowsData : ScriptableObject
{
    public List<CrossbowData> CrossbowList = new();
    private void OnValidate()
    {
        foreach (var data in CrossbowList)
        {
            data.TypeWeapon = TypeWeapon.Sniper;
            data.AimTime = 1.2f;
            data.FireRate = 40f;
            data.Range = 34f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 2;
            data.Cooldown = 10f;
        }
    }
}

[System.Serializable]
public class CrossbowData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float AimTime;
}
