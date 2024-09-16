using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Intansce_ListItem : MonoBehaviour
{
    [SerializeField] private GameObject listItemPrefab;
    void Start()
    {
        
    }

    public void CallListItem()
    {
        Instantiate(listItemPrefab, transform.position, transform.rotation);
    }
}
