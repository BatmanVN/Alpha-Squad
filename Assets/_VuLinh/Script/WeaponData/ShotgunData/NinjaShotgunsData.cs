using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NinjaShotgunsData", menuName = "ShotgunTypeOST/NinjaShotgunsData", order = 5)]
public class NinjaShotgunsData : ScriptableObject
{
    public List<NinjaShotgunData> NinjaShotgunList = new();
    private void OnValidate()
    {
        foreach (var data in NinjaShotgunList)
        {
            data.TypeWeapon = TypeWeapon.Shotgun;
            data.Bullets = 5;
            data.FireRate = 200f;
            data.Range = 15f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 3;
            data.Cooldown = 5f;
        }
    }
}
[System.Serializable]
public class NinjaShotgunData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Bullets;
}