using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detected_Player : MonoBehaviour
{
    [SerializeField] private Collider detector;
    private bool deteced;

    public bool Deteced { get => deteced; set => deteced = value; }

    private void OnTriggerEnter(Collider detector)
    {
        if (detector.CompareTag("Player"))
        {
            Deteced = true;
        }
    }
}
