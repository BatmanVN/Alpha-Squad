using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shoot_Pistol : Shoot
{
    private const string shootParaname = "Shoot";
    
    [SerializeField] private Transform enemy;
    [SerializeField] private int rpm;
    [SerializeField] private float speedBullet;
    [SerializeField] private Animator animShoot;
    [SerializeField] private UnityEvent onShoot;
    [SerializeField] private SkullHealth skullHealth;
    [SerializeField] private BulletType bulletType;
    [SerializeField] private float dame;
    private int countBullet;
    private float _interval;
    private float _lastShot;
    private void Start() => _interval = 60f / rpm;

    public void UpdateFiring()
    {
        if(Time.time - _lastShot > _interval)
        {
            transform.LookAt(enemy);
            //ShootPistol();
            animShoot.SetTrigger("Shoot");
            onShoot?.Invoke();
            _lastShot = Time.time;
            
        }
    }

    //private void ShootPistol()
    //{
    //    GameObject bullet = SimplePool.Spawn<>
    //    bullet.GetComponent<Rigidbody>().velocity = transform.forward * speedBullet;
    //    countBullet++;
    //}
    protected PoolType GetPoolTypeByBulletType()
    {
        if (bulletType == BulletType.BulletPlayer)
            return PoolType.BulletPlayer;
        return PoolType.BulletEnemy;
    }
    public void Deliverdame()
    {
        skullHealth.TakeDame(dame);
    }
    private void Update()
    {
    }
    
}
