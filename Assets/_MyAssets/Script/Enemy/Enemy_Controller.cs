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
    }

    private void SetActiveComponents(bool isActive)
    {
        foreach(var component in components)
        {
            component.enabled = isActive;
        }
    }

    private void EnableComponents()
    {
        SetActiveComponents(true);
    }
    private void DisableComponents()
    {
        SetActiveComponents(false);
        collider3D.enabled = false;
        nav.isStopped = true;
        healthBar.SetActive(false);
    }
    private void Update()
    {
        if (!isPlay)
        {
            return;
        }
    }
}
