using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTabs : MonoBehaviour
{
    [SerializeField] private List<CategoryUI> categories = new List<CategoryUI>();
    //[SerializeField] private List<GameObject> buttonTabs;
    //[SerializeField] private List<GameObject> button;

    ////private int indexs;
    ////private bool isTouch;
    private void Start()
    {
        
    }
    public void ChangeTab(int index)
    {
        for (int i = 0; i < categories.Count; i++)
        {
            if (categories[i] == categories[index])
                categories[index].SelectButton();
            else
                categories[i].Disalbe();
            Debug.Log("Run");
        }
        //for (int i = 0; i < button.Count; i++)
        //{
        //    button[i].SetActive(buttonTabs[i] == buttonTabs[index]);
        //}
    }
}
