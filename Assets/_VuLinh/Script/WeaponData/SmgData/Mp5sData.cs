using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mp5sData", menuName = "SmgTypeOST/Mp5sData", order = 3)]
public class Mp5sData : ScriptableObject
{
    public List<Mp5Data> mp5List = new();
    private void OnValidate()
    {
        foreach (var data in mp5List)
        {
            data.TypeWeapon = TypeWeapon.SMG;
            data.Accuracy = 801;
            data.FireRate = 469;
            data.Range = 12f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 18;
            data.Cooldown = 5f;
        }
    }
}

[System.Serializable]
public class Mp5Data : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float DPS;
}