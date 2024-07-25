using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_move : MonoBehaviour
{
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private Transform player;
    //[SerializeField] private AudioSource footStep;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject A;
    [SerializeField] private GameObject B;
    [SerializeField] private float distanceStop;
    private Transform currentPoint;
    private bool deteced;
    private void Start()
    {
        currentPoint = B.transform;
        //nav = GetComponent<NavMeshAgent>();
    }
    private void Move()
    {
        if(currentPoint == A.transform && nav.remainingDistance < 2f)
        {
            currentPoint = B.transform;
        }
        else if (currentPoint == B.transform && nav.remainingDistance < 2f)
        {
            currentPoint = A.transform;
        }
        else if(deteced == true)
        {
            currentPoint = player;
            if(Vector3.Distance(transform.position, player.position) <= distanceStop)
            {
                nav.isStopped = true;
            }
            else
            {
                nav.isStopped = false;
            }
        }
        RunAnim();
        nav.SetDestination(currentPoint.position);
    }
    private void RunAnim()
    {
        if (nav.isStopped == false)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }
    private void OnTriggerEnter(Collider detector)
    {
        if(detector.CompareTag("Player"))
        {
            deteced = true;
        }
    }
    private void Update()
    {
            Move(); 
    }
}
