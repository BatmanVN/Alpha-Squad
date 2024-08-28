using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRandomItem : MonoBehaviour
{
    [SerializeField] private GameObject[] listItem;
    [SerializeField] private Transform enemy;
    [SerializeField] private Rigidbody rigs;
    [SerializeField] private Vector3 direction;
    private int random;

    private void Start()
    {
        random = Random.Range(0, listItem.Length);
        Debug.Log("Random: " + random);
    }

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
