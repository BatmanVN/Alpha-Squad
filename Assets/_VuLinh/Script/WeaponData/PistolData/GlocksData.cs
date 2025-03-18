using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GlocksData", menuName = "PistolTypeOST/GlocksData", order = 2)]
public class GlocksData : ScriptableObject
{
    public List<DataGlockType> glockList = new();
    private void OnValidate()
    {
        foreach (var data in glockList)
        {
            data.Accuracy = 801;
            data.FireRate = 171;
            data.Range = 14f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 8;
            data.Cooldown = 2.5f;
        }
    }
}

[System.Serializable]
public class DataGlockType : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}
