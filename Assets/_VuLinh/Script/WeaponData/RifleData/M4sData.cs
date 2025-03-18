using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "M4sData", menuName = "RilfeTypeOST/M4sData", order = 4)]
public class M4sData : ScriptableObject
{
    public List<M4Data> M4List = new();
    private void OnValidate()
    {
        foreach (var data in M4List)
        {
            data.TypeWeapon = TypeWeapon.Rifle;
            data.Accuracy = 882f;
            data.FireRate = 444f;
            data.Range = 18f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 30;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class M4Data : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}
