using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Controller : MonoBehaviour
{
    [SerializeField] private HealthComponent health;
    [SerializeField] private List<MonoBehaviour> components;
    [SerializeField] private Collider collider3D;
    [SerializeField] private GameObject healthBar;
    [SerializeField] private GameObject indicator;

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
        TurnOff();
    }
    private void TurnOff()
    {
        collider3D.enabled = false;
        healthBar.SetActive(false);
        indicator.SetActive(false);
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

    }
    private void Update()
    {
        if (!isPlay)
        {
            return;
        }
    }
}
