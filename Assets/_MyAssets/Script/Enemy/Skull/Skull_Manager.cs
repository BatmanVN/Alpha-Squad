using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull_Manager : HealthComponent
{
    [SerializeField] private float amorIndex;
    [SerializeField] private float maxHealth;
    [SerializeField] private float health;

    private void Awake()
    {
        MaxHealth = maxHealth;
    }
    private void Start()
    {
        health = maxHealth;
    }
    public override void TakeDame(float dame)
    {
        dame -= amorIndex;
        base.TakeDame(dame);
    }    
}
