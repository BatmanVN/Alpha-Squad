using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play_Button : MonoBehaviour
{
    //[SerializeField] private ProgressBar progress;
    [SerializeField] private string sceneName;
    [SerializeField] private float fakeDuration;
    [SerializeField] private Image fillLoading;
    private AsyncOperation loadingOperation;
    private float startTime;

    public void StartLoadScene()
    {
        gameObject.SetActive(true);
        DontDestroyOnLoad(this);
        startTime = 0.2f;
        loadingOperation = SceneManager.LoadSceneAsync(sceneName);
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (loadingOperation == null) return;
        startTime += 0.01f;
        fillLoading.fillAmount = startTime / fakeDuration;
        //float finalProgress = Mathf.Min(fakeProgress, loadingOperation.progress);
        //progress.SetProgressValue(finalProgress);
        if (loadingOperation.isDone && fillLoading.fillAmount == 1f)
        {
            FinshLoading();
        }
    }

    private void FinshLoading()
    {
        Time.timeScale = 1;
        Destroy(gameObject);
    }
}
