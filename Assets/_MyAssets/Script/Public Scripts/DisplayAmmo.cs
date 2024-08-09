using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAmmo : MonoBehaviour
{
    [SerializeField] private GunAmmo ammo;
    [SerializeField] private Text ammoText;
    [SerializeField] private Image foreGround;
    private void Start()
    {
        ammo.onChangeAmmoValue.AddListener(DisplayAmmoText);
        DisplayAmmoText();
    }
    public void DisplayAmmoText()
    {
        ammoText.text = ammo.LoadAmmo.ToString();
        foreGround.fillAmount = ammo.LoadAmmo / ammo.Magsize;
    }
}
