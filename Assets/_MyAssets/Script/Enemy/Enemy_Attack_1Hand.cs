using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack_1Hand : MonoBehaviour
{
    private const string attackParaname = "Attack";
    private const string idleParaname = "Idle";
    private Enemy_move _Move;
    private Animator _animEnemy;
    private float _dame;
   [SerializeField] private int rpm;

    private float _lastAttack;
    private float _interval;
    public float Dame { get => _dame; set => _dame = value; }

    private void Start()
    {
        _interval = 60f / rpm;
        _Move = GetComponent<Enemy_move>();
        _animEnemy = GetComponentInChildren<Animator>();
    }
    private void UpdateFiring()
    {
        if(Time.time - _lastAttack >= _interval)
        {
            Attack();
            _lastAttack = Time.time;

        }
        //if(Time.time - _lastAttack < _interval)
        //{
        //    _animEnemy.SetBool("Idle",true);
        //}
    }
    private void Attack()
    {
        if(_Move.Nav.isStopped == true)
        {
            _animEnemy.SetTrigger(attackParaname);
            _animEnemy.SetBool("Idle", true);
        }
        else
        {
            _animEnemy.SetBool("Idle", false);
        }
    }
    private void Update()
    {
        UpdateFiring();
    }
}
