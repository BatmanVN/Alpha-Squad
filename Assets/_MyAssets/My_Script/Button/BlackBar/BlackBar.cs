using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackBar : MonoBehaviour
{
    [SerializeField] private Image blackBar;
    [SerializeField] private float alpha;
    private void EndMap()
    {
        Color color = blackBar.color;
        color.a += alpha;
    }
    private void Update()
    {
        EndMap();
    }
}