using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonInPause : Singleton<ButtonInPause>
{
    [SerializeField] private GameObject pauseBar;
    [SerializeField] private GameObject joyStick;
    [SerializeField] private Play_Button scene;
    [SerializeField] private string sceneMap;
    public void ClickLeave()
    {
        scene.StartLoadScene();
        Time.timeScale = 1;
    }
    public void ClickRestart()
    {
        scene.SceneName = sceneMap;
        scene.StartLoadScene();
        Time.timeScale = 1;
    }
    public void ClickResum()
    {
        EnableJoyStick();
        pauseBar.SetActive(false);
        Time.timeScale = 1;
    }
    private void EnableJoyStick()
    {
        joyStick.SetActive(true);
    }
    private void Update()
    {

    }
}
