using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _health;
    //public UnityEvent onTakeDame;
    public UnityEvent onDie;
    public UnityEvent<float, float> onChangedHealth;

    public float MaxHealth { get => _maxHealth; protected set => _maxHealth = value; }
    public float Health 
    { 
        get => _health;
        set
        {
            _health = value;
            onChangedHealth?.Invoke(_health, _maxHealth);
        }
    }

    public bool dead => Health <= 0;

    private void Start()
    {
        Health = MaxHealth;
    }
    public virtual void TakeDame(float dame)
    {
        if (dead) return;
        Health -= dame;
        //onTakeDame.Invoke();
        if (dead)
        {
            OnDie();
        }
    }
    protected virtual void OnDie()
    {
        onDie?.Invoke();
    }
}
