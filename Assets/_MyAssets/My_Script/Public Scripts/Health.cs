using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [field: SerializeField] public float maxHealth { get; set; }
    [SerializeField] private float healthPoint;

    public UnityEvent onDie;
    public UnityEvent<float, float> onChangedHealth;

    public float HealthPoint
    { 
        get => healthPoint;
        set
        {
            healthPoint = value;
            onChangedHealth?.Invoke(healthPoint, maxHealth);
        }
    }

    public bool dead => healthPoint <= 0;

    private void Start()
    {
        HealthPoint = maxHealth;
    }
    public virtual void TakeDame(float dame)
    {
        if (dead) return;
        HealthPoint -= dame;
        if (dead)
            OnDie();
    }
    protected virtual void OnDie()
    {
        onDie?.Invoke();
    }
}
