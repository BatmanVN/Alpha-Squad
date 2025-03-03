using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AgentRarety
{
    Common,
    Uncommon,
    Exceptional,
    Rare,
    Epic,
}
[CreateAssetMenu(fileName = "AgentData", menuName = "ScriptableObjects/AgentData", order = 1)]
public class AgentData : ScriptableObject
{
    public List<Agent> agentData = new List<Agent>();
}

[System.Serializable]
public class Agent
{
    [HorizontalGroup("Split", 75)]
    [HideLabel]
    [PreviewField(75)]
    [VerticalGroup("Split/Left")]
    public Sprite agentSprite;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public string agentName;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public string personalGun;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Health;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public float Damage;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public int Level;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public AgentRarety Rarety;

    [VerticalGroup("Split/Right")]
    [LabelWidth(100)]
    public GameObject AgentPrefab;
}
