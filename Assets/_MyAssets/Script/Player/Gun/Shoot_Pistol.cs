using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Lean.Pool;

public class Shoot_Pistol : Shoot
{
    private const string shootParaname = "Shoot";
    [SerializeField] private LeanGameObjectPool spawnBullet;
    [SerializeField] private Transform enemy;
    [SerializeField] private int rpm;
    [SerializeField] private float speedBullet;
    [SerializeField] private Animator animShoot;
    [SerializeField] private ConditionToShoot condition;
    [SerializeField] private UnityEvent onShoot;
    [SerializeField] private SkullHealth skullHealth;
    [SerializeField] private float dame;
    private int countBullet;
    private float _interval;
    private float _lastShot;
    private void Start() => _interval = 60f / rpm;

    public void UpdateFiring()
    {
        if(Time.time - _lastShot > _interval)
        {
            ShootPistol();
            //Onshoot();
            onShoot?.Invoke();
            _lastShot = Time.time;
        }
    }

    public void ShootPistol()
    {
        GameObject bullet = spawnBullet.Spawn(pointBullet.position, pointBullet.rotation);
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * speedBullet;
        countBullet++;
    }

    public void DespawnBullet()
    {
        if(countBullet == 5)
            spawnBullet.DespawnOldest();
    }
    public void Deliverdame()
    {
        skullHealth.TakeDame(dame);
    }
    public void Onshoot() => animShoot.SetBool(shootParaname,true);
    public void OutShoot() => animShoot.SetBool(shootParaname, false);
    private void Update()
    {
        DespawnBullet();
        if(condition.OnShoot == true)
        {
            UpdateFiring();
        }
        Debug.Log(countBullet);
    }
    
}
