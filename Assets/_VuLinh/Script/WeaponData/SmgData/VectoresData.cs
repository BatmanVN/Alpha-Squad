using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VectoresData", menuName = "SmgTypeOST/VectoresData", order = 3)]
public class VectoresData : ScriptableObject
{
    public List<VectorData> VectorList = new();
    private void OnValidate()
    {
        foreach (var data in VectorList)
        {
            data.TypeWeapon = TypeWeapon.SMG;
            data.Accuracy = 1779;
            data.FireRate = 1000;
            data.Range = 11f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 15;
            data.Cooldown = 5f;
        }
    }
}

[System.Serializable]
public class VectorData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float DPS;
}
