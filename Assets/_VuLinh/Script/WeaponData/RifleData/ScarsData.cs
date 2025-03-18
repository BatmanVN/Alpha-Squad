using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScarsData", menuName = "RilfeTypeOST/ScarsData", order = 4)]
public class ScarsData : ScriptableObject
{
    public List<ScarData> ScarList = new();
    private void OnValidate()
    {
        foreach (var data in ScarList)
        {
            data.TypeWeapon = TypeWeapon.Rifle;
            data.Accuracy = 910f;
            data.FireRate = 429f;
            data.Range = 16f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 30;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class ScarData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}