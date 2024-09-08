using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private RectTransform mask;
    [SerializeField] private RectTransform progressImage;

    private float maxWidth;
    private float maxHeight;

    private void Awake()
    {
        maxWidth = mask.rect.width;
        maxHeight = mask.rect.height;
    }

    public void SetProgressValue(float progress)
    {
        float currenWidth = Mathf.Clamp01(progress) * maxWidth;
        mask.sizeDelta = new Vector2(currenWidth, maxHeight);
    }
    private void Update()
    {
        
    }
}
