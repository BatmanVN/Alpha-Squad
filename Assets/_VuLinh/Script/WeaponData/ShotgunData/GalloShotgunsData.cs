using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GalloShotgunsData", menuName = "ShotgunTypeOST/GalloShotgunsData", order = 5)]
public class GalloShotgunsData : ScriptableObject
{
    public List<GalloShotgunData> GalloShotgunList = new();
    private void OnValidate()
    {
        foreach (var data in GalloShotgunList)
        {
            data.TypeWeapon = TypeWeapon.Shotgun;
            data.Bullets = 7;
            data.FireRate = 200f;
            data.Range = 8f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 12;
            data.Cooldown = 12.5f;
        }
    }
}
[System.Serializable]
public class GalloShotgunData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Bullets;
}
