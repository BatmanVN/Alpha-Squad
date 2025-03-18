using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpringfieldsData", menuName = "SniperTypeOST/SpringfieldsData", order = 6)]

public class SpringfieldsData : ScriptableObject
{
    public List<SpringfieldData> SpringfieldList = new();
    private void OnValidate()
    {
        foreach (var data in SpringfieldList)
        {
            data.TypeWeapon = TypeWeapon.Sniper;
            data.AimTime = 0.8f;
            data.FireRate = 80f;
            data.Range = 31f;
            data.CritChance = 10f;
            data.CritDame = 2f;
            data.Ammo = 6;
            data.Cooldown = 10f;
        }
    }
}
[System.Serializable]
public class SpringfieldData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float AimTime;
}