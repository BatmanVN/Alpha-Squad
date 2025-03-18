using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MagnumsData", menuName = "PistolTypeOST/MagnumsData", order = 2)]
public class MagnumsData : ScriptableObject
{
    public List<MagnumPistolData> MagnumList = new();
    private void OnValidate()
    {
        foreach (var data in MagnumList)
        {
            data.Accuracy = 983f;
            data.FireRate = 133f;
            data.Range = 15f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 6;
            data.Cooldown = 2.5f;
        }
    }
}

[System.Serializable]
public class MagnumPistolData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}
