using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Enemy_move : MonoBehaviour
{
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private Transform player;
    [SerializeField] private Detected_Player detec;
    [SerializeField] private GameObject A;
    [SerializeField] private GameObject B;
    [SerializeField] private float distanceStop;
    [SerializeField] private float angleAttack;
    [SerializeField] private UnityEvent destinationReached;
    [SerializeField] private UnityEvent startMoving;
    private Transform currentPoint;
    //private bool canAttack;
    public NavMeshAgent Nav { get => nav; set => nav = value; }

    private void Start()
    {
        currentPoint = B.transform;
    }
    private void Move()
    {
        if(currentPoint == A.transform && Nav.remainingDistance < 2f)
        {
            currentPoint = B.transform;
        }
        else if (currentPoint == B.transform && Nav.remainingDistance < 2f)
        {
            currentPoint = A.transform;
        }
        else if(detec.Deteced == true)
        {
            currentPoint = player;
            //CheckLookPlayer();
            if (Vector3.Distance(transform.position, player.position) <= distanceStop)
            {
                //if(canAttack == true)
                //{
                    Nav.isStopped = true;
                //}
                    destinationReached.Invoke();
            }
            else if(Vector3.Distance(transform.position, player.position) > distanceStop)
            {
                //if (canAttack == false)
                //{
                    Nav.isStopped = false;
                //}
                    startMoving.Invoke();
            }
        }
        Nav.SetDestination(currentPoint.position);
    }
    //private void CheckLookPlayer()
    //{
    //    Vector3 direction = player.position - transform.position;
    //    Quaternion target = Quaternion.LookRotation(player.position);
    //    transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
    //    angleAttack = Vector3.Angle(transform.forward, direction);
    //    if(angleAttack < 10f)
    //    {
    //        canAttack = true;
    //    }
    //}
    private void Update()
    {
            Move(); 
    }
}
