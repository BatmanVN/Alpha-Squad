using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public enum PistolType
{
    Glock,
    Alien,
    Magnum,
    Pinky,
    Gadget
}

[CreateAssetMenu(fileName = "PistolAllType", menuName = "ListGuns/PistolAllType", order = 1)]
public class PistolAllType : ScriptableObject
{
    public List<PistolsTypeData> Pistolsdata;
}

[System.Serializable]
public class PistolsTypeData
{
    public PistolType TypePistol;

    public ScriptableObject PistolTypeSOT;
}