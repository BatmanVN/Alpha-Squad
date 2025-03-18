using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BerrettasData", menuName = "SniperTypeOST/BerrettasData", order = 6)]
public class BerrettasData : ScriptableObject
{
    public List<BerrettaData> BerrettaList = new();
    private void OnValidate()
    {
        foreach (var data in BerrettaList)
        {
            data.TypeWeapon = TypeWeapon.Sniper;
            data.AimTime = 1f;
            data.FireRate = 48f;
            data.Range = 35f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 3;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class BerrettaData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float AimTime;
}
