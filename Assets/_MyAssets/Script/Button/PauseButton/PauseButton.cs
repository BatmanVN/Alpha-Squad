using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject pauseBar;
    [SerializeField] private GameObject joyStick;


    public void EnablePauseBar()
    {
        HideJoyStick();
        pauseBar.SetActive(true);
        Time.timeScale = 0;
    }

    private void HideJoyStick()
    {
        joyStick.SetActive(false);
    }
}
