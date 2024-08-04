using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shoot_Pistol : Shoot
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private int rpm;
    [SerializeField] private float speedBullet;
    [SerializeField] private UnityEvent onShoot;

    private float _interval;
    private float _lastShot;
    private void Start() => _interval = 60f / rpm;


}
