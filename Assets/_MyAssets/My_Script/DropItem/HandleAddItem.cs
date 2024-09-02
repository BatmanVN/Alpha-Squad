using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleAddItem : MonoBehaviour
{
    [SerializeField] private GameObject[] listItem;
    [SerializeField] private Transform enemy;
    [SerializeField] private Rigidbody rigs;
    [SerializeField] private Vector3 direction;
    [SerializeField] private int random;

    //Set random thu tu 1 item dc bat
    private void Start()
    {
        random = Random.Range(0, listItem.Length);
        Debug.Log("Random: " + random);
    }

    //Bat obj Item Drop tu vi tri cua quai vat & gan rig cho obj item do
    //Add = tay
    public void DropItem()
    {
        for (int i = 0; i < listItem.Length; i++)
        {
            if (i == random)
            {
                listItem[i].SetActive(true);
                listItem[i].transform.position = enemy.position;
                rigs = listItem[i].GetComponent<Rigidbody>();
                rigs.velocity = direction;
            }
        }
    }
}
