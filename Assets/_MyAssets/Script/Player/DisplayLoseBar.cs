using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayLoseBar : MonoBehaviour
{
    [SerializeField] private GameObject loseBar;
    [SerializeField] private GameObject joyStick;
    public void WhenDie()
    {
        loseBar.SetActive(true);
        joyStick.SetActive(false);
        Time.timeScale = 0;
    }
}
