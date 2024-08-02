using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Enemy_move : MonoBehaviour
{
    private const string runParaname = "Run";
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private Transform player;
    [SerializeField] private Animator anim;
    [SerializeField] private Detected_Player detec;
    [SerializeField] private float distanceStop;
    [SerializeField] private UnityEvent destinationReached;
    [SerializeField] private UnityEvent startMoving;
    private bool _ismoving;
    public bool Moving 
    { 
        get => _ismoving;
        set
        {
            if (_ismoving == value) return;
            _ismoving = value;
            InvokeRepeating(nameof(OnIsValueChanged), 0f, 2f);
        }
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnIsValueChanged()
    {
        nav.isStopped = !_ismoving;
        anim.SetBool(runParaname, _ismoving);
        if(Moving)
        {
            startMoving.Invoke();
        }
        else
        {
            destinationReached.Invoke();
        }
    }

    private void Move()
    {
        var distance = Vector3.Distance(transform.position, player.position);
       if (detec.Deteced == true)
        {
            Moving = distance > distanceStop;
            if(Moving)
            {
                nav.SetDestination(player.position);
            }
        }
    }
    private void Update()
    {
        Move();
    }
}
