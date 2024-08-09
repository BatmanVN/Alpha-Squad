using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shoot_Pistol : Shoot
{
    private const string shootParaname = "Shoot";
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform enemy;
    [SerializeField] private int rpm;
    [SerializeField] private float speedBullet;
    [SerializeField] private Animator animShoot;
    [SerializeField] private UnityEvent onShoot;

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
        Vector3 shootToEnemy = (enemy.position - pointBullet.position).normalized;
        bullet.GetComponent<Rigidbody>().velocity = shootToEnemy * speedBullet;
    }
    public void Onshoot() => animShoot.SetTrigger(shootParaname);
    private void Update()
    {
        
    }
}
