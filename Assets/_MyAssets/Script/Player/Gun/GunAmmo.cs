using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunAmmo : MonoBehaviour
{
    [SerializeField] private float _magsize;
    //[SerializeField] private Shoot gun;
    [SerializeField] private float _loadAmmo;
    [SerializeField] private UnityEvent onloadAmmo;

    private void Start()
    {
        RefillAmmo();
    }
    public float LoadAmmo
    {
        get => _loadAmmo;
        set
        {
            _loadAmmo = value;
            onloadAmmo?.Invoke();
            if(_loadAmmo <= 0)
            {
                //LockShooting();
            }
            else
            {
                //UnlockShooting();
            }
        }
    }

    //private void UnlockShooting()
    //{
    //    gun.enabled = true;
    //}

    //private void LockShooting()
    //{
    //    gun.enabled = false;
    //}

    private void RefillAmmo() => LoadAmmo = _magsize;
}
