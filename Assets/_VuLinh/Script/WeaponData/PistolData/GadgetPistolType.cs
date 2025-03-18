using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GadgetPistolType", menuName = "PistolTypeOST/GadgetPistolType", order = 2)]
public class GadgetPistolType : ScriptableObject
{
    public List<GadgetPistolData> GadgetList = new();
    private void OnValidate()
    {
        foreach (var data in GadgetList)
        {
            data.Accuracy = 466f;
            data.FireRate = 1200f;
            data.Range = 11f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 30;
            data.Cooldown = 2.5f;
        }
    }
}

[System.Serializable]
public class GadgetPistolData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}
