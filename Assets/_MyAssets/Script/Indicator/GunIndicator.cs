using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunIndicator : MonoBehaviour
{
    [SerializeField] private GameObject[] indicator;
    [SerializeField] private Transform enemy;
    private void Update()
    {
        
    }

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
    //[SerializeField] private GameObject[] indicators;
    //private string[] rangGun = new string[] {"RangeAim", "Range_pistol" };   
    //private void OnTriggerEnter(Collider indicator)
    //{
    //    for(int i = 0; i < rangGun.Length; i++)
    //    {
    //        if(indicator.CompareTag(rangGun[0]))
    //        {
    //            indicators[0].SetActive(true);
    //        }
    //        if (indicator.CompareTag(rangGun[i]))
    //        {
    //            indicators[i].SetActive(true);
    //            indicators[0].SetActive(false);
    //        }
    //    }
    //}
    //private void OnTriggerExit(Collider indicator)
    //{
    //    for (int i = 0; i < rangGun.Length; i++)
    //    {
    //        if (indicator.CompareTag(rangGun[0]))
    //        {
    //            indicators[0].SetActive(false);
    //        }
    //         if (indicator.CompareTag(rangGun[i]))
    //        {
    //            indicators[i].SetActive(false);
    //            indicators[0].SetActive(true);
    //        }
    //    }
    //}
}
