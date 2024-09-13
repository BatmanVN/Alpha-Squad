using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenChest : MonoBehaviour
{
    //[SerializeField] private GameObject VFX;
    [SerializeField] private Animator anim;
    public UnityEvent onOpenchest;
    public UnityEvent onDropItem;
    private bool opened;

    public void CanOpenChest()
    {
        if(!opened)
        {
            //VFX.SetActive(true);
            anim.SetTrigger("LB_Start");
            opened = true;
            onOpenchest?.Invoke();
        }
    }

    public void DropItem()
    {
        onDropItem?.Invoke();
    }
    private void Start()
    {
        
    }
}
