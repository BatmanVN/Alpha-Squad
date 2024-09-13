using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// tạo 1 class CategoryDropItem để quản lý tất cả các Item Drop sau đó sẽ định nghĩa , tạo hành động cho các item ở đây rồi gọi ở thằng khác
/// </summary>
public class CategoryDropItem : MonoBehaviour
{
    [SerializeField] private GameObject item;
    [SerializeField] private Rigidbody itemRB;
    [SerializeField] private Vector3 direction;
    [SerializeField] private Transform enemy;
    [SerializeField] private Transform player;

    private bool dropped;
    private void Start()
    {

    }
    /// <summary>
    /// Drop item will add all component of Item & active Obj Item and transform drop
    /// </summary>
    public void DropItem()
    {
        itemRB = item.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        item.SetActive(true);
        item.transform.position = enemy.position;
        itemRB.velocity = direction;
        dropped = true;
    }
    /// <summary>
    /// RangeToCollect measure distance of Item to Player and update status disable will close player
    /// </summary>
    /// <param name="rangeCollect"></param>
    /// <param name="rangeDestroy"></param>
    /// <param name="speed"></param>
    public void RangeToCollect(float rangeCollect, float rangeDestroy, float speed)
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        var range = Vector3.Distance(player.position, item.transform.position);
        if (range <= rangeCollect)
            item.transform.position = Vector3.MoveTowards(item.transform.position, player.transform.position, speed * Time.deltaTime);
        if (range < rangeDestroy)
            DisableItem();
    }

    public void DisableItem()
    {
        if (dropped)
            item.SetActive(false);
    }
}
