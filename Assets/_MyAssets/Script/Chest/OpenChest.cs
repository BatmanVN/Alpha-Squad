using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] private GameObject VFX;
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private Animator anim;
    private bool opened;

    public void CanOpenChest()
    {
        if(opened == false)
        {
            VFX.SetActive(true);
            anim.SetTrigger("LB_Open1");
            particle.Play();
            opened = true;
        }
    }
}