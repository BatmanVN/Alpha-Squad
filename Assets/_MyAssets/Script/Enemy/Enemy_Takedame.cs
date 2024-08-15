using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy_Takedame : MonoBehaviour
{
    [SerializeField] private UnityEvent onTakeDame;
    private void OnTriggerEnter(Collider enemy)
    {
        if (enemy.CompareTag("Bullet"))
        {
            onTakeDame?.Invoke();
        }
    }
}
