using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose_Weapon : MonoBehaviour
{

    [SerializeField] private GameObject[] buttonChooseGun;
    [SerializeField] private GameObject[] iconSelected;
    [SerializeField] private Sprite[] backgroundRank;
    [SerializeField] private Image[] showRank;
    [SerializeField] private Vector2[] obj;
    [SerializeField] private bool[] clicked;
    [SerializeField] private int yPostion;
    public void ChooseGun(int index)
    {
        for(int i = 0; i < buttonChooseGun.Length; i++)
        {
            if(clicked[i] == false)
            {
                if (i == index)
                {
                    buttonChooseGun[i].transform.position = new Vector2(buttonChooseGun[i].transform.position.x, buttonChooseGun[i].transform.position.y + yPostion);
                    iconSelected[i].SetActive(true);
                    clicked[i] = true;
                }
            }
            if(i != index)
            {
                clicked[i] = false;
                buttonChooseGun[i].transform.position = obj[i];
                iconSelected[i].SetActive(false);
            }
        }
    }
    private void Start()
    {
        buttonChooseGun[0].transform.position = new Vector2(buttonChooseGun[0].transform.position.x, buttonChooseGun[0].transform.position.y + yPostion);
        iconSelected[0].SetActive(true);
        clicked[0] = true;
    }
}
