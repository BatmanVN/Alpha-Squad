using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DoubleShotgunsData", menuName = "ShotgunTypeOST/DoubleShotgunsData", order = 5)]
public class DoubleShotgunsData : ScriptableObject
{
    public List<DoubleShotgunData> DoubleShotgunList = new();
    private void OnValidate()
    {
        foreach (var data in DoubleShotgunList)
        {
            data.TypeWeapon = TypeWeapon.Shotgun;
            data.Bullets = 6;
            data.FireRate = 300f;
            data.Range = 10f;
            data.CritChance = 5f;
            data.CritDame = 2f;
            data.Ammo = 2;
            data.Cooldown = 5f;
        }
    }
}
[System.Serializable]
public class DoubleShotgunData : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Bullets;
}
