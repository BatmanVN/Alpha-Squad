using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlasmasData", menuName = "RilfeTypeOST/PlasmasData", order = 4)]
public class PlasmasData : ScriptableObject
{
    public List<PlasmaData> PlasmaList = new();
    private void OnValidate()
    {
        foreach (var data in PlasmaList)
        {
            data.TypeWeapon = TypeWeapon.Rifle;
            data.Accuracy = 801f;
            data.FireRate = 300f;
            data.Range = 18f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 22;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class PlasmaData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}