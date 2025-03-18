using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "AlienPistolsType", menuName = "PistolTypeOST/AlienPistolsType", order = 2)]
public class AlienPistolsType : ScriptableObject
{
    public List<AlienPistolData> AlienPistolList = new();
    private void OnValidate()
    {
        foreach (var data in AlienPistolList)
        {
            data.Accuracy = 801;
            data.FireRate = 240;
            data.Range = 16f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 9;
            data.Cooldown = 2.5f;
        }
    }
}

[System.Serializable]
public class AlienPistolData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}
