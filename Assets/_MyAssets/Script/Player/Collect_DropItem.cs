using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collect_DropItem : MonoBehaviour
{
    public UnityEvent onCollect;
    private void OnTriggerEnter(Collider player)
    {
        if(player.CompareTag("DropItem"))
        {
            onCollect?.Invoke();
        }
    }
}
