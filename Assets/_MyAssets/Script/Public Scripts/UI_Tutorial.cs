using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Tutorial : MonoBehaviour
{

    [SerializeField] private GameObject buttonChooseGun;
    [SerializeField] private GameObject iconSelected;
    [SerializeField] private Vector2 obj;
    [SerializeField] private bool clicked;
    [SerializeField] private int yPostion;
    public void ChooseGun(int index)
    {

            if (clicked == false)
            {
                    buttonChooseGun.transform.position = new Vector2(buttonChooseGun.transform.position.x, buttonChooseGun.transform.position.y + yPostion);
                    iconSelected.SetActive(true);
                    clicked = true;
            }
                clicked = false;
                buttonChooseGun.transform.position = obj;
                iconSelected.SetActive(false);

    }
    private void Start()
    {

        buttonChooseGun.transform.position = new Vector2(buttonChooseGun.transform.position.x, buttonChooseGun.transform.position.y + yPostion);
        iconSelected.SetActive(true);
        clicked = true;
    }
}
