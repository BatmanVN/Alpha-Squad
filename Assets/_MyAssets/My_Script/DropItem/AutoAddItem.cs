using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAddItem : MonoBehaviour
{
    [SerializeField] private List<CategoryDropItem> items = new List<CategoryDropItem>();
    [SerializeField] private int random;
    [SerializeField] private float speed;
    [SerializeField] private float rangeCollect;
    [SerializeField] private float rangeDestroy;
    //Set random thu tu 1 item dc bat
    //Add auto
    private void Start()
    {
        random = Random.Range(0, items.Count);
    }
    public void DropItems()
    {
        //for (int i = 0; i < items.Count; i++)
        //{
                items[random].DropItem(/*items[i] == items[random]*/);
        //}
    }
    private void CollectItem()
    {
        items[random].RangeToCollect(rangeCollect,rangeDestroy,speed);
    }
    //public void CollectedItem()
    //{
    //    items[random].DisableItem();
    //}
    private void Update()
    {
        CollectItem();
    }

}
