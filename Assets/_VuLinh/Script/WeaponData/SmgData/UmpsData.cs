using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UmpsData", menuName = "SmgTypeOST/UmpsData", order = 3)]
public class UmpsData : ScriptableObject
{
    public List<UmpData> UmpList = new();
    private void OnValidate()
    {
        foreach (var data in UmpList)
        {
            data.TypeWeapon = TypeWeapon.SMG;
            data.Accuracy = 983;
            data.FireRate = 444;
            data.Range = 13f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 20;
            data.Cooldown = 5f;
        }
    }
}

[System.Serializable]
public class UmpData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float DPS;
}
