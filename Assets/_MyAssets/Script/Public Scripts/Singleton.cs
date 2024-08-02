using System;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                T intanceInscene = FindAnyObjectByType<T>();
                ResigterIntance(intanceInscene);
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance == null)
        {
            ResigterIntance((T)(MonoBehaviour)this);
        }
        else if (_instance != this)
        {
            Destroy(this);
        }
    }
    private static void ResigterIntance(T newIntance)
    {
        if (newIntance == null)
            _instance = newIntance;
        DontDestroyOnLoad(_instance.transform.root.gameObject);
    }
}
