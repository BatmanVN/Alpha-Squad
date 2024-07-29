using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    private float _maxHealth;
    private float _health;

    public float MaxHealth { get => _maxHealth; protected set => _maxHealth = value; }
    public float Health { get => _health; protected set => _health = value; }

    public bool dead => Health <= 0;

    private void Start()
    {
        Health = MaxHealth;
    }
    public virtual void TakeDame(float dame)
    {
        if(!dead)
        {
            Health -= dame;
        }
        else
        {
            return;
        }
    }
}
