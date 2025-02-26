using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SmgData", menuName = "ScriptableObjects/SmgData", order = 1)]
public class SmgData : ScriptableObject
{
    public List<Smg> data;
}

[System.Serializable]
public class Smg : BaseStatsWeapon, IAccuracy
{
    public float Accuracy { get; set; }
    public float DPS;

}