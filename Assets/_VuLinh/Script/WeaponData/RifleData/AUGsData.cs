using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AUGsData", menuName = "RilfeTypeOST/AUGsData", order = 4)]
public class AUGsData : ScriptableObject
{
    public List<AUGData> AUGList = new();
    private void OnValidate()
    {
        foreach (var data in AUGList)
        {
            data.TypeWeapon = TypeWeapon.Rifle;
            data.Accuracy = 840f;
            data.FireRate = 400f;
            data.Range = 17f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 30;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class AUGData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}
