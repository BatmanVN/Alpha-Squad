using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shoot : MonoBehaviour
{
    public Transform pointBullet;
    public float TimeDelay;
    private bool isLockedValue;
    private float damage;
    private float fireRate;
    private float rangeIndicator;
    private float critChance;
    private float critDame;
    private float coolDown;

    public bool IsLocked 
    { 
        get => isLockedValue; 
        set
        {
            isLockedValue = value;
            enabled = !isLockedValue;
        }
    }

    public float Damage { get => damage; set => damage = value; }
}

