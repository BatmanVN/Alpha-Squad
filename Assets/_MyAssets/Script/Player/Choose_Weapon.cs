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
    //private void ShowBackgroundRank()
    //{
    //    for (int i = 0; i < showRank.Length; i++)
    //    {
    //        WeaponRankType rankType = GetRandomEnumValue<WeaponRankType>();
    //        switch (rankType)
    //        {
    //            case WeaponRankType.Common:
    //                i = 0;
    //                break;
    //            case WeaponRankType.Uncommon:
    //                i = 1;
    //                break;
    //            case WeaponRankType.Rare:
    //                i = 2;
    //                break;
    //            case WeaponRankType.Epic:
    //                i = 3;
    //                break;
    //            case WeaponRankType.Mythic:
    //                i = 4;
    //                break;
    //            case WeaponRankType.Legendary:
    //                i = 5;
    //                break;
    //        }
    //        showRank[i].sprite = backgroundRank[i];
    //    }
    //}
    //public T GetRandomEnumValue<T>() where T : Enum
    //{
    //    Array values = Enum.GetValues(typeof(T));
    //    return (T)values.GetValue(UnityEngine.Random.Range(0, values.Length));
    //}
    private void Start()
    {
        //ShowBackgroundRank();
        buttonChooseGun[0].transform.position = new Vector2(buttonChooseGun[0].transform.position.x, buttonChooseGun[0].transform.position.y + yPostion);
        iconSelected[0].SetActive(true);
        clicked[0] = true;
    }
}
