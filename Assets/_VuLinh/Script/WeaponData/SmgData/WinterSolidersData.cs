using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WinterSolidersData", menuName = "SmgTypeOST/WinterSolidersData", order = 3)]
public class WinterSolidersData : ScriptableObject
{
    public List<WinterSoliderData> WinterSoliderList = new();
    private void OnValidate()
    {
        foreach (var data in WinterSoliderList)
        {
            data.TypeWeapon = TypeWeapon.SMG;
            data.Accuracy = 676;
            data.FireRate = 500;
            data.Range = 14f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 18;
            data.Cooldown = 5f;
        }
    }
}

[System.Serializable]
public class WinterSoliderData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float DPS;
}
