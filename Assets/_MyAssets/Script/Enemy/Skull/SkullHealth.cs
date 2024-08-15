using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullHealth : HealthComponent
{
    [SerializeField] private float amorIndex;

    public override void TakeDame(float dame)
    {
        dame -= amorIndex;
        base.TakeDame(dame);
    }    
}
