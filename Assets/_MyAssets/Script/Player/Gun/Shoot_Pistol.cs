using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Lean.Pool;

public class Shoot_Pistol : Shoot
{
    private const string shootParaname = "Shoot";
    [SerializeField] private LeanGameObjectPool spawnBullet;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform enemy;
    [SerializeField] private int rpm;
    [SerializeField] private float speedBullet;
    [SerializeField] private Animator animShoot;
    [SerializeField] private int currentBullet;
    [SerializeField] private UnityEvent onShoot;
    [SerializeField] private SkullHealth skullHealth;
    //[SerializeField] private UnityEvent onTakeDame;
    [SerializeField] private float dame;

    //private bool onTrigger;
    private float _interval;
    private float _lastShot;
    private void Start() => _interval = 60f / rpm;

    public void UpdateFiring()
    {
        if(Time.time - _lastShot > _interval)
        {
            ShootPistol();
            Onshoot();
            onShoot?.Invoke();
            _lastShot = Time.time;
        }
    }

    private void ShootPistol()
    {
        GameObject bullet = Instantiate(bulletPrefab, pointBullet.position, pointBullet.rotation);
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * speedBullet;
    }
    public void Deliverdame()
    {
        skullHealth.TakeDame(dame);
    }
    public void Onshoot() => animShoot.SetTrigger(shootParaname);
    private void Update()
    {
        
    }
    
}
