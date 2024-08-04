using System;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                T instanceInScene = FindAnyObjectByType<T>();
                RegsisterInstance(instanceInScene);
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance == null)
        {
            RegsisterInstance((T)(MonoBehaviour)this);
        }
        else if (_instance != this)
        {
            Destroy(this);
        }
    }

    private static void RegsisterInstance(T newInStance)
    {
        if (newInStance == null) return;
        _instance = newInStance;
        DontDestroyOnLoad(_instance.transform.root.gameObject);
    }
} 
