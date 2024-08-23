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
    public UnityEvent onDisableIndicator;
    public UnityEvent onShoot;
    public void OnIndicator()
    {
        var indicator = Vector3.Distance(transform.position, enemy.position);
        if (indicator > whiteToEnemy)
        {
            onDisableIndicator?.Invoke();
        }
        if (indicator <= whiteToEnemy && indicator > redToEnemy)
        {
            onWhiteIndicator?.Invoke();
            anim.SetBool("Aim", false);
        }
        if (indicator <= redToEnemy)
        {
            transform.LookAt(enemy);
            onRedIndicator?.Invoke();
            anim.SetBool("Aim",true);
            onShoot?.Invoke();
        }
    }
}
