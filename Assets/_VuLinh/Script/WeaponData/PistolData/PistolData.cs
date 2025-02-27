using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PistolData", menuName = "ScriptableObjects/PistolData", order = 1)]
public class PistolData : ScriptableObject
{
    public List<Pistol> data;
}

[System.Serializable]
public class Pistol : BaseStatsWeapon
{
    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Accuracy;
}