using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUp : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject blackBar;
    void Start()
    {
        
    }

    public void MoveUp()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        player.parent = transform;
        blackBar.SetActive(true);
    }
}
