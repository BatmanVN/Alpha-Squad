using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PumpShotgunsData", menuName = "ShotgunTypeOST/PumpShotgunsData", order = 5)]
public class PumpShotgunsData : ScriptableObject
{
    public List<PumpShotgunData> PumpShotgunList = new();
    private void OnValidate()
    {
        foreach (var data in PumpShotgunList)
        {
            data.TypeWeapon = TypeWeapon.Shotgun;
            data.Bullets = 6;
            data.FireRate = 120f;
            data.Range = 9f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 4;
            data.Cooldown = 7.5f;
        }
    }
}
[System.Serializable]
public class PumpShotgunData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Bullets;
}
