using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] private GameObject VFX;
    [SerializeField] private Animator anim;
    private bool opened;

    public void CanOpenChest()
    {
        if(!opened)
        {
            VFX.SetActive(true);
            anim.SetTrigger("LB_Start");
            opened = true;
        }
    }
}
