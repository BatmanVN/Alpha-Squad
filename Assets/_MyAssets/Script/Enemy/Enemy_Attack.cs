using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    private const string attackParaname = "Attack";
    [SerializeField] private Animator _animEnemy;
    [SerializeField] private HealthComponent playerHealth;
    [SerializeField] private float _dame;
    //[SerializeField] private int rpm;
    //private float _lastAttack;
    //private float _interval;

    private void Start()
    {
        //_interval = 60f / rpm;
        _animEnemy = GetComponent<Animator>();
    }
    //public void UpdateFiring()
    //{
    //    if (Time.time - _lastAttack >= _interval)
    //    {
    //         StartAttack();
    //        _lastAttack = Time.time;
    //    }
    //}
    public void StartAttack() => _animEnemy.SetBool(attackParaname,true);
    public void StopAttack() => _animEnemy.SetBool(attackParaname, false);
    public void OnAttack()
    {
        playerHealth.TakeDame(_dame);
    }
}
