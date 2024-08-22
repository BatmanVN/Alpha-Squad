using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunAmmo : MonoBehaviour
{
    [SerializeField] private float _magsize;
    [SerializeField] private Shoot gun;
    [SerializeField] private float _loadAmmo;

    public UnityEvent onChangeAmmoValue;
    public UnityEvent onLockShooting;
    public UnityEvent onUnlockShooting;

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
            onChangeAmmoValue?.Invoke();
            if(_loadAmmo <= 0)
            {
                LockShooting();
                
            }
            else
            {
                UnlockShooting();
            }
        }
    }

    public float Magsize { get => _magsize; set => _magsize = value; }

    private void UnlockShooting()
    {
        gun.IsLocked = true;
        onUnlockShooting?.Invoke();
    }

    private void LockShooting()
    {
        onLockShooting?.Invoke();
        gun.IsLocked = false;
        StartCoroutine(DelayUnlock());
    }
    private IEnumerator DelayUnlock()
    {
        yield return new WaitForSeconds(gun.TimeDelay);
        RefillAmmo();
    }
    public void ammoChangeValue() => LoadAmmo--;
    private void RefillAmmo() => LoadAmmo = Magsize;
}
