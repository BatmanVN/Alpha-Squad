using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Observer : MonoBehaviour
{
    static Dictionary<Type, Dictionary<Enum, List<Action<object[]>>>> Listeners =
        new Dictionary<Type, Dictionary<Enum, List<Action<object[]>>>>();
    public static void AddObserver<T>(T type, Action<object[]> callback) where T : Enum
    {
        var enumType = typeof(T);
        if (!Listeners.ContainsKey(enumType))
        {
            Listeners[enumType] = new Dictionary<Enum, List<Action<object[]>>>();
        }
        if (!Listeners[enumType].ContainsKey(type))
        {
            Listeners[enumType].Add(type, new List<Action<object[]>>());
        }
        Listeners[enumType][type].Add(callback);
    }
    public static void RemoveObserver<T>(T type, Action<object[]> callback) where T : Enum
    {
        var enumType = typeof(T);
        if (!Listeners.ContainsKey(enumType)) return;
        if (!Listeners[enumType].ContainsKey(type)) return;
        Listeners[enumType][type].Remove(callback);
    }
    public static void Notify<T>(T type, params object[] datas) where T : Enum
    {
        var enumType = typeof(T);
        if (!Listeners.ContainsKey(enumType)) return;
        if (!Listeners[enumType].ContainsKey(type)) return;
        foreach (var item in Listeners[enumType][type])
        {
            try
            {
                item?.Invoke(datas);
            }
            catch (Exception e)
            {   
                Debug.LogError("Error on invoke: " + e);
            }
        }
    }
}
