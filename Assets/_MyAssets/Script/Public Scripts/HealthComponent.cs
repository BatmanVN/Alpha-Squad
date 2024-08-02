using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _health;
    public UnityEvent<float> onAttack;

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
            onAttack.Invoke(Health);
        }
        else
        {
            return;
        }
    }
}
