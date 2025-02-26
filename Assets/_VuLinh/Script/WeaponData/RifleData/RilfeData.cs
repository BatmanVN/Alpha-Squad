using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RilfeData", menuName = "ScriptableObjects/RilfeData", order = 1)]
public class RilfeData : ScriptableObject
{
    public List<Rilfe> data;
}

[System.Serializable]
public class Rilfe : BaseStatsWeapon, IAccuracy
{
    public float Accuracy { get; set; }
}