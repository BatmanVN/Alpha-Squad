using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SniperType
{
    ScifiSniper,
    Barreta,
    Springfield,
    Crossbow,
    SilencerSniper
}

[CreateAssetMenu(fileName = "SniperAllType", menuName = "ListGuns/SniperAllType", order = 1)]
public class SniperAllType : ScriptableObject
{
    public List<SniperTypeData> Sniperstype;
}

[System.Serializable]
public class SniperTypeData
{
    public SniperType TypeSniper;

    public ScriptableObject SniperTypeSOT;
}