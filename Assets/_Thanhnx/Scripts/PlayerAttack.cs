using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _timeDelay;

    [SerializeField] private float _bulletSpeed;

    [SerializeField] private Transform _pointShooting;
    private float _nextShootTime;


    private void Update()
    {
        if(!CanShoot()) return;
        Shooting();
    }
    private void Shooting(){
        _nextShootTime = Time.time + _timeDelay;
        GameObject bullet = Instantiate(_bulletPrefab);
        bullet.transform.position = _pointShooting.position;
        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * _bulletSpeed;
    }

    private bool CanShoot(){
        if(Time.time >= _nextShootTime ) return true;
        return false;
    }
}
