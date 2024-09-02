using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusRealoading : MonoBehaviour
{
    [SerializeField] private GameObject realoadingBar;

    public void EnableRealoadbar() => realoadingBar.SetActive(true);
    public void DisableRealoadbar() => realoadingBar.SetActive(false);
}
