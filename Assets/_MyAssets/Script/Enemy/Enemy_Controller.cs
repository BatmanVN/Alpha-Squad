using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Controller : MonoBehaviour
{
    [SerializeField] private HealthComponent health;
    [SerializeField] private List<MonoBehaviour> components;
    [SerializeField] private Collider collider3D;
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private GameObject healthBar;
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody[] rig;

    private bool isPlay;

    private void Start()
    {
        Live();
    }
    private void Live()
    {
        isPlay = true;
        EnableComponents();
    }
    public void Dead()
    {
        isPlay = false;
        DisableComponents();
        collider3D.enabled = false;
        nav.isStopped = true;
        healthBar.SetActive(false);
        anim.enabled = false;
        SetRagdoll();
    }

    private void SetActiveComponents(bool isActive)
    {
        foreach(var component in components)
        {
            component.enabled = isActive;
        }
    }
    public void SetRagdoll()
    {
        for (int i = 0; i < rig.Length; i++)
        {
            rig[i].isKinematic = false;
        }
    }
    private void EnableComponents()
    {
        SetActiveComponents(true);
    }
    private void DisableComponents()
    {
        SetActiveComponents(false);

    }
    private void Update()
    {
        if (!isPlay)
        {
            return;
        }
    }
}
