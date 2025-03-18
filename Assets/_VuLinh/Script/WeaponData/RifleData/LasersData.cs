using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LasersData", menuName = "RilfeTypeOST/LasersData", order = 4)]
public class LasersData : ScriptableObject
{
    public List<LaserData> LaserList = new();
    private void OnValidate()
    {
        foreach (var data in LaserList)
        {
            data.TypeWeapon = TypeWeapon.Rifle;
            data.Accuracy = 752f;
            data.FireRate = 367f;
            data.Range = 15.5f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 25;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class LaserData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}
