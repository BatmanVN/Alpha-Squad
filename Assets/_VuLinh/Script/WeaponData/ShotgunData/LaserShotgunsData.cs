using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "LaserShotgunsData", menuName = "ShotgunTypeOST/LaserShotgunsData", order = 5)]
public class LaserShotgunsData : ScriptableObject
{
    public List<LaserShotgunData> LaserShotgunList = new();
    private void OnValidate()
    {
        foreach (var data in LaserShotgunList)
        {
            data.TypeWeapon = TypeWeapon.Shotgun;
            data.Bullets = 5;
            data.FireRate = 150f;
            data.Range = 11.5f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 5;
            data.Cooldown = 7.5f;
        }
    }
}
[System.Serializable]
public class LaserShotgunData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Bullets;
}
