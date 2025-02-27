using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SmgData", menuName = "ScriptableObjects/SmgData", order = 1)]
public class SmgData : ScriptableObject
{
    public List<Smg> smgData;
    private void OnValidate()
    {
        foreach (Smg smg in smgData)
        {
            smg.TypeWeapon = TypeWeapon.SMG;
        }
    }

}

[System.Serializable]
public class Smg : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float DPS;

}