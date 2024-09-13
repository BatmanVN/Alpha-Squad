using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collect_DropItem : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform itemDrop;
    [SerializeField] private float rangeCollect;
    [SerializeField] private float rangeDestroy;
    public UnityEvent onCollect;
    public UnityEvent onDestroy;
    private void RangeToCollect()
    {
        itemDrop = GameObject.FindGameObjectWithTag("DropItem").GetComponent<Transform>();
        var range = Vector3.Distance(player.position, itemDrop.position);
        if (range <= rangeCollect)
            onCollect?.Invoke();
        if (range < rangeDestroy)
            onDestroy?.Invoke();
    }
    private void Update()
    {
        RangeToCollect();
    }

}
