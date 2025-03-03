using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager _instance;

    public static DataManager Instance
    {
        get
        {
            if (_instance) return _instance;

            _instance = FindObjectOfType<DataManager>();
            if (_instance != null) return _instance;

            var obj = new GameObject("DataManager");
            _instance = obj.AddComponent<DataManager>();
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else if (_instance == null) _instance = this;

        DontDestroyOnLoad(this);
    }
}