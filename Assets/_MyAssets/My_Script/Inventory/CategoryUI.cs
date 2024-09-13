using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryUI : MonoBehaviour
{
    //public GameObject button;
    public GameObject select;

    public void SelectButton()
    {
        select.SetActive(true);
    }
    public void Disalbe()
    {
        select.SetActive(false);
    }
}
