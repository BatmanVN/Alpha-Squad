using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "P90sData", menuName = "SmgTypeOST/P90sData", order = 3)]
public class P90sData : ScriptableObject
{
    public List<P90Data> P90List = new();
    private void OnValidate()
    {
        foreach (var data in P90List)
        {
            data.TypeWeapon = TypeWeapon.SMG;
            data.Accuracy = 801;
            data.FireRate = 750;
            data.Range = 12f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 26;
            data.Cooldown = 5f;
        }
    }
}

[System.Serializable]
public class P90Data : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float DPS;
}