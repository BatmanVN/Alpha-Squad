using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    [SerializeField] private ProgressBar progress;
    [SerializeField] private string sceneName;
    [SerializeField] private float fakeDuration;
    private AsyncOperation loadingOperation;
    private float startTime;

    public void StartLoadScene()
    {
        gameObject.SetActive(true);
        DontDestroyOnLoad(this);
        startTime = Time.unscaledTime;
        loadingOperation = SceneManager.LoadSceneAsync(sceneName);
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (loadingOperation == null) return;
        float fakeProgress = (Time.unscaledTime - startTime) / fakeDuration;
        float finalProgress = Mathf.Min(fakeProgress, loadingOperation.progress);
        progress.SetProgressValue(finalProgress);
        if (loadingOperation.isDone && finalProgress >= 1f)
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
