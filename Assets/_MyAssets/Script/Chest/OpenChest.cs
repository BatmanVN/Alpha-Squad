using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenChest : MonoBehaviour
{
    [SerializeField] private GameObject VFX;
    [SerializeField] private Animator anim;
    public UnityEvent onOpenchest;
    private bool opened;

    public void CanOpenChest()
    {
        if(!opened)
        {
            VFX.SetActive(true);
            anim.SetTrigger("LB_Start");
            opened = true;
            onOpenchest?.Invoke();
        }
    }
    private void Start()
    {
        
    }
}
