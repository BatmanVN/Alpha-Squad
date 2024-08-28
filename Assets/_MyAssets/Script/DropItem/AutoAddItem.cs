using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAddItem : MonoBehaviour
{
    [SerializeField] private List<GameObject> items;
    [SerializeField] private Transform enemy;
    [SerializeField] private Rigidbody rigs;
    [SerializeField] private Vector3 direction;
    [SerializeField] private int random;

    //Set random thu tu 1 item dc bat
    //Add auto
    private void Start()
    {
        random = Random.Range(0, transform.childCount);
        AddItemDrop();
        Debug.Log("random: " + random);
    }
    public void AddItemDrop()
    {
        foreach (Transform child in transform)
        {
            items.Add(child.gameObject);
        }
    }
    public void DropItem()
    {
          items[random].SetActive(true);
          items[random].transform.position = enemy.position;
          rigs = items[random].GetComponent<Rigidbody>();
          rigs.velocity = direction;
    }
}
