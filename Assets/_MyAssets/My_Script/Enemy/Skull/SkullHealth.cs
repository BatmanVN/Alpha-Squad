using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SkullHealth : Health
{
    [SerializeField] private float amorIndex;
    public UnityEvent onOpenchest;
    public override void TakeDame(float dame)
    {
        dame -= amorIndex;
        base.TakeDame(dame);
    }
    public void ActiveChest()
    {
        if (dead)
        {
            onOpenchest?.Invoke();
        }
    }
    //public void DestroyObjec()
    //{

    //}
    private void Update()
    {
        ActiveChest();
    }
}
