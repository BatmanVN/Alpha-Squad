using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StatusElevator : MonoBehaviour
{
    private const string nameStates = "openstate";
    [SerializeField] private Animator animator;
    public UnityEvent onMoveup;
    void Start()
    {
        
    }
    public void OpenElevator()
    {
        animator.SetInteger(nameStates,1);
    }
    public void CloseElevator()
    {
        animator.SetInteger(nameStates, 2);
    }
    public void MoveOut()
    {
        animator.SetInteger(nameStates, 3);
        onMoveup?.Invoke();
    }
    private void OnTriggerEnter(Collider elevator)
    {
        if (elevator.CompareTag("Player"))
        {
            CloseElevator();
        }
    }
}
