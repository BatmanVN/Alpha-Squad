using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AKsData", menuName = "RilfeTypeOST/AKsData", order = 4)]
public class AKsData : ScriptableObject
{
    public List<AKData> AkList = new();
    private void OnValidate()
    {
        foreach (var data in AkList)
        {
            data.TypeWeapon = TypeWeapon.Rifle;
            data.Accuracy = 801f;
            data.FireRate = 333f;
            data.Range = 16f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 30;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class AKData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}