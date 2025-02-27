using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RilfeData", menuName = "ScriptableObjects/RilfeData", order = 1)]
public class RilfeData : ScriptableObject
{
    public List<Rilfe> rifleData;
    private void OnValidate()
    {
        foreach (Rilfe rifle in rifleData)
        {
            rifle.TypeWeapon = TypeWeapon.Rifle;
        }
    }
}

[System.Serializable]
public class Rilfe : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}