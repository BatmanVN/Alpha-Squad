using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SMGType
{
    P90,
    UMP,
    Pulse,
    MP5,
    Vector,
    WinterSolider
}

[CreateAssetMenu(fileName = "SMGAllType", menuName = "ListGuns/SMGAllType", order = 1)]
public class SMGAllType : ScriptableObject
{
    public List<SmgTypeData> SmgTypesdata;
}

[System.Serializable]
public class SmgTypeData
{
    public SMGType TypeSmg;

    public ScriptableObject SMGTypeSOT;
}