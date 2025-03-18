using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "R9ShotgunsData", menuName = "ShotgunTypeOST/R9ShotgunsData", order = 5)]

public class R9ShotgunsData : ScriptableObject
{
    public List<R9ShotgunData> R9ShotgunList = new();
    private void OnValidate()
    {
        foreach (var data in R9ShotgunList)
        {
            data.TypeWeapon = TypeWeapon.Shotgun;
            data.Bullets = 8;
            data.FireRate = 171f;
            data.Range = 10f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 6;
            data.Cooldown = 7.5f;
        }
    }
}
[System.Serializable]
public class R9ShotgunData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Bullets;
}
