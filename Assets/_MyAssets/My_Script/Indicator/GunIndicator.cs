using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunIndicator : MonoBehaviour
{
    [SerializeField] private List<GameObject> indicators;

    private void Start()
    {
        AddIndicator();
    }
    private void AddIndicator()
    {
        foreach (Transform child in transform)
        {
            indicators.Add(child.gameObject);
        }
    }

    public void EnableWhiteIndicator()
    {
        indicators[0].SetActive(true);
        indicators[1].SetActive(false);
    }

    public void EnableRedIndicator()
    {
        indicators[0].SetActive(false);
        indicators[1].SetActive(true);
    }

    public void DisableWhiteIndicator() => indicators[0].SetActive(false);
}
