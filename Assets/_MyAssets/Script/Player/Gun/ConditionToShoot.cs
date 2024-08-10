using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConditionToShoot : MonoBehaviour
{
    [SerializeField] private Transform enemy;
    [SerializeField] private float whiteToEnemy;
    [SerializeField] private float redToEnemy;
    [SerializeField] private Animator anim;
    //[SerializeField] private HealthComponent healthEnemy;
    public UnityEvent onWhiteIndicator;
    public UnityEvent onRedIndicator;
    public UnityEvent onShoot;
    public void OnIndicator()
    {
        var indicator = Vector3.Distance(transform.position, enemy.position);
        if (indicator <= whiteToEnemy && indicator > redToEnemy)
        {
            onWhiteIndicator?.Invoke();
        }
        else if (indicator <= redToEnemy)
        {
            onRedIndicator?.Invoke();
            anim.SetTrigger("Aiming");
            transform.LookAt(enemy);
            onShoot?.Invoke();
        }
    }

}
