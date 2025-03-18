using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RilfeType
{
    AUG,
    Plasma,
    AK,
    M4,
    Laser,
    SCAR
}

[CreateAssetMenu(fileName = "RilfeAllType", menuName = "ListGuns/RilfeAllType", order = 1)]
public class RilfeAllType : ScriptableObject
{
    public List<RilfeTypeData> Rilfestype;
}

[System.Serializable]
public class RilfeTypeData
{
    public RilfeType TypeRilfe;

    public ScriptableObject RilfeTypeSOT;
}