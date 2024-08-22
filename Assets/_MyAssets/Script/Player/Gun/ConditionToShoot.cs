using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConditionToShoot : MonoBehaviour
{
    private const string aimParaname = "Aiming";
    [SerializeField] private Transform enemy;
    [SerializeField] private float whiteToEnemy;
    [SerializeField] private float redToEnemy;
    [SerializeField] private Animator anim;
    public UnityEvent onWhiteIndicator;
    public UnityEvent onRedIndicator;
    public UnityEvent onDisableIndicator;
    private bool _onShoot;

    public bool OnShoot
    {
        get => _onShoot;
        set
        {
            _onShoot = value;
        }
    }
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
            OnShoot = false;
        }
        if (indicator <= redToEnemy)
        {
            onRedIndicator?.Invoke();
            //anim.SetTrigger(aimParaname);
            transform.LookAt(enemy);
            OnShoot = true;
        }
    }
    private void Update()
    {
        OnIndicator();
    }
}
