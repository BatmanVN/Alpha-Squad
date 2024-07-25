using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose_Weapon : MonoBehaviour
{
    [SerializeField] private GameObject[] buttonChooseGun;
    [SerializeField] private Vector2[] obj;
    [SerializeField] private bool[] clicked;
    
    //[SerializeField] private Vector2 xPostion;
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
                    clicked[i] = true;
                }
            }
            if(i != index)
            {
                clicked[i] = false;
                buttonChooseGun[i].transform.position = obj[i];
            }
        }
    }
    //private void Update()
    //{
    //    ChooseGun();
    //}
}
