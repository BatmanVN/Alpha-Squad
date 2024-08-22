using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform pointBullet;
    public float TimeDelay;
    private bool isLockedValue;

    public bool IsLocked
    {
        get => isLockedValue;
        set
        {
            isLockedValue = value;
            enabled = !isLockedValue;
        }
    }
}

