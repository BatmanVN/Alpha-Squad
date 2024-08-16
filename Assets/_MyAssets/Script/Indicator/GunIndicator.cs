using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunIndicator : MonoBehaviour
{
    [SerializeField] private GameObject[] indicator;
    [SerializeField] private Transform enemy;

    public void EnableWhiteIndicator()
    {
        indicator[0].SetActive(true);
        indicator[1].SetActive(false);
    }

    public void EnableRedIndicator()
    {
        indicator[0].SetActive(false);
        indicator[1].SetActive(true);
    }

    public void DisableWhiteIndicator() => indicator[0].SetActive(false);
}
