using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PistolData", menuName = "ScriptableObjects/PistolData", order = 1)]
public class PistolData : ScriptableObject
{
    public List<PistolData> data;
}

[System.Serializable]
public class Pistol : BaseStatsWeapon, IAccuracy
{
    public float Accuracy { get; set; }
}