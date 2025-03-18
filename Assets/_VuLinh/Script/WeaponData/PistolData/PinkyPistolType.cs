using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PinkyPistolType", menuName = "PistolTypeOST/PinkyPistolType", order = 2)]
public class PinkyPistolType : ScriptableObject
{
    public List<PinkyPistolData> PinkyPistolList = new();
    private void OnValidate()
    {
        foreach (var data in PinkyPistolList)
        {
            data.Accuracy = 676;
            data.FireRate = 200f;
            data.Range = 15f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 12;
            data.Cooldown = 2.5f;
        }
    }
}

[System.Serializable]
public class PinkyPistolData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}
