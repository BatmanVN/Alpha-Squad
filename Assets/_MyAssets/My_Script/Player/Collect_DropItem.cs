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
    public void RangeToCollect()
    {
        itemDrop = GetComponentInChildren<Transform>();
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
    private void OnDrawGizmos()
    {
        Color color = Color.red;
        Gizmos.DrawWireSphere(player.position, rangeCollect);
        Gizmos.DrawWireSphere(player.position, rangeDestroy);
    }
}