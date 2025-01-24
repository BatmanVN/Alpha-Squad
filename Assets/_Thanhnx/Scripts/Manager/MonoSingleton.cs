using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; protected set; }

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Debug.Log($"Already has a {typeof(T)} in scene. This instance will be ignored", gameObject);
            enabled = false;
        }
        else
        {
            Instance = this as T;
        }
    }

    protected virtual void OnDestroy()
    {
        Instance = null;
    }
}