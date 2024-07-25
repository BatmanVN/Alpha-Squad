using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_move : MonoBehaviour
{
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private Transform player;
    [SerializeField] private Detected_Player detec;
    //[SerializeField] private Animator anim;
    [SerializeField] private GameObject A;
    [SerializeField] private GameObject B;
    [SerializeField] private float distanceStop;
    private Transform currentPoint;

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
            if(Vector3.Distance(transform.position, player.position) <= distanceStop)
            {
                Nav.isStopped = true;
            }
            else
            {
                Nav.isStopped = false;
            }
        }
        //RunAnim();
        Nav.SetDestination(currentPoint.position);
    }
    //private void RunAnim()
    //{
    //    if (Nav.isStopped == false)
    //    {
    //        anim.SetBool(runParaname, true);
    //    }
    //    else
    //    {
    //        anim.SetBool(runParaname, false);
    //    }
    //}
    private void Update()
    {
            Move(); 
    }
}
