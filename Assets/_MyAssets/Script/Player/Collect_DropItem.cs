using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collect_DropItem : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform itemDrop;
    [SerializeField] private float rangeCollect;
    public UnityEvent onCollect;

    public void RangeToCollect()
    {
        var range = Vector3.Distance(player.position,itemDrop.position);
        if (range <= rangeCollect)
        {
            onCollect?.Invoke();
        }
    }
    private void Update()
    {
        RangeToCollect();
    }
}
