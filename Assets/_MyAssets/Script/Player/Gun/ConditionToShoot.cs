using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConditionToShoot : MonoBehaviour
{
    [SerializeField] private Transform enemy;
    [SerializeField] private Transform player;
    [SerializeField] private float whiteToEnemy;
    [SerializeField] private float redToEnemy;
    [SerializeField] private Animator anim;
    public UnityEvent onWhiteIndicator;
    public UnityEvent onRedIndicator;
    public UnityEvent onDisableIndicator;
    public UnityEvent onShoot;
    public void OnIndicator()
    {
        var indicator = Vector3.Distance(player.position, enemy.position);
        if (indicator > whiteToEnemy)
        {
            onDisableIndicator?.Invoke();
        }
        if (indicator <= whiteToEnemy && indicator > redToEnemy)
        {
            onWhiteIndicator?.Invoke();
        }
        if (indicator <= redToEnemy)
        {
            player.LookAt(enemy);
            onRedIndicator?.Invoke();
            onShoot?.Invoke();
        }
    }
}
