using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AutoAddItem : MonoBehaviour
{
    [SerializeField] private List<CategoryDropItem> items = new List<CategoryDropItem>();
    [SerializeField] private int random;
    [SerializeField] private float speed;
    [SerializeField] private float rangeCollect;
    [SerializeField] private float rangeDestroy;
    //Set random thu tu 
    private void Start()
    {
        //random = Random.Range(0, items.Count);
    }
    public void DropItems()
    {
        random = Random.Range(0, items.Count);
        items[random].DropItem();
    }
    private void CollectItem()
    {
        items[random].RangeToCollect(rangeCollect,rangeDestroy,speed);
    }
    private void Update()
    {
        CollectItem();
    }

}
