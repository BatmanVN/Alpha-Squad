using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PulsesData", menuName = "SmgTypeOST/PulsesData", order = 3)]
public class PulsesData : ScriptableObject
{
    public List<PulseData> PulseList = new();
    private void OnValidate()
    {
        foreach (var data in PulseList)
        {
            data.TypeWeapon = TypeWeapon.SMG;
            data.Accuracy = 983;
            data.FireRate = 423;
            data.Range = 13f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 18;
            data.Cooldown = 5f;
        }
    }
}

[System.Serializable]
public class PulseData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float DPS;
}
