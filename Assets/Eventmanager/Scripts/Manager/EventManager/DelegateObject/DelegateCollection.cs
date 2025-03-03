using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _Game.Scripts.Manager.EventManager.DelegateObject;
using UnityEditor;
using UnityEngine;

namespace _Game.Scripts.Manager.EventManager.DelegateObject
{
    [SerializeField]
    public class DelegateCollection<T> : IEnumerable where T : Delegate
    {
        public List<DelegateInfo<T>> Delegates = new();

        public void Add(T @delegate, GameObject debugContext = null)
        {
            Delegates.Add(new(@delegate, debugContext));
        }

        public void Remove(T @delegate)
        {
            for (int i = 0; i < Delegates.Count; i++)
            {
                if (Delegates[i].Delegate == @delegate)
                {
                    Delegates.RemoveAt(i);
                    return;
                }
            }
#if UNITY_EDITOR
            Debug.LogWarning("NAB - Không tìm thấy delegate để remove kiểm tra lại code");
#endif
        }

        public bool Contain(T @delegate)
        {
            return Delegates.Any(item => item.Delegate == @delegate);
        }

        public void Clear()
        {
            if (Delegates != null)
            {
                Delegates.Clear();
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public DelegateEnum<T> GetEnumerator()
        {
            return new(Delegates);
        }
#if UNITY_EDITOR
        public int Count()
        {
            return Delegates.Count;
        }

        public string GetTarget()
        {
            string target = "";

            if (Delegates != null)
            {
                foreach (var item in Delegates)
                {
                    target += item.Delegate != null && item.Delegate.Target != null ? item.Delegate.Target.ToString() : "null";
                }
            }

            return target;
        }
#endif
    }


    // When you implement IEnumerable, you must also implement IEnumerator.
    public class DelegateEnum<T> : IEnumerator where T : Delegate
    {
        public readonly List<DelegateInfo<T>> _delegates;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        private int _position = -1;

        public DelegateEnum(List<DelegateInfo<T>> list)
        {
            _delegates = list;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _delegates.Count;
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current => Current;

        public T Current
        {
            get
            {
                try
                {
                    return _delegates[_position].Delegate;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    [Serializable]
    public struct DelegateInfo<T> where T : Delegate
    {
#if UNITY_EDITOR
        public string     Name;
        public GameObject Context;
#endif
        public T Delegate;

        public DelegateInfo(T @delegate)
        {
#if UNITY_EDITOR
            Name = $"{@delegate.Target}.{@delegate.Method.Name}";
            Context = null;
#endif
            Delegate = @delegate;
        }

        public DelegateInfo(T @delegate, GameObject context)
        {
#if UNITY_EDITOR
            Name = $"{@delegate.Target}.{@delegate.Method.Name}";
            Context = context;
#endif
            Delegate = @delegate;
        }
    }

#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(DelegateCollection<>))]
    public class DelegateCollectionDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property.FindPropertyRelative("Delegates"), true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property.FindPropertyRelative("Delegates"), label);
            GUI.enabled = true;
        }
    }
#endif
}

public static class DelegateHelper
{
    //GỌi tất cả action trong list Delegate này
    public static void Invoke(this DelegateCollection<Action> delegateCollection)
    {
        if (delegateCollection == null || delegateCollection.Delegates == null)
        {
            return;
        }

        for (int i = delegateCollection.Delegates.Count - 1; i >= 0; i--)
        {
            if (delegateCollection.Delegates[i].Delegate != null)
            {
                delegateCollection.Delegates[i].Delegate.Invoke();
            }
        }
        // foreach (var @delegate in delegateCollection.Delegates)
        // {
        //     @delegate.Delegate?.Invoke();
        // }
    }

    //Giống Obeserver (object[] datas) => truyền 1 tham số, và Invoke<T> để truyền kiểu dữ liệu
    public static void Invoke<T>(this DelegateCollection<Action<T>> delegateCollection, T param)
    {
        if (delegateCollection == null || delegateCollection.Delegates == null)
        {
            return;
        }

        for (int i = delegateCollection.Delegates.Count - 1; i >= 0; i--)
        {
            if (delegateCollection.Delegates[i].Delegate != null)
            {
                delegateCollection.Delegates[i].Delegate.Invoke(param);
            }
        }
        // foreach (var @delegate in delegateCollection.Delegates)
        // {
        //     @delegate.Delegate?.Invoke(param);
        // }
    }

    //Giống Obeserver (object[] datas) => truyền 2 tham số, và Invoke<T,TY> để truyền kiểu dữ liệu
    public static void Invoke<T, TY>(this DelegateCollection<Action<T, TY>> delegateCollection, T param, TY param1)
    {
        if (delegateCollection == null || delegateCollection.Delegates == null)
        {
            return;
        }

        for (int i = delegateCollection.Delegates.Count - 1; i >= 0; i--)
        {
            if (delegateCollection.Delegates[i].Delegate != null)
            {
                delegateCollection.Delegates[i].Delegate.Invoke(param, param1);
            }
        }
        // foreach (var @delegate in delegateCollection.Delegates)
        // {
        //     @delegate.Delegate?.Invoke(param);
        // }
    }

    //Giống Obeserver (object[] datas) => truyền 3 tham số, và Invoke<T,TY,TR> để truyền kiểu dữ liệu
    public static void Invoke<T, TY, TR>(this DelegateCollection<Action<T, TY, TR>> delegateCollection, T param, TY param1, TR param2)
    {
        if (delegateCollection == null || delegateCollection.Delegates == null)
        {
            return;
        }

        for (int i = delegateCollection.Delegates.Count - 1; i >= 0; i--)
        {
            if (delegateCollection.Delegates[i].Delegate != null)
            {
                delegateCollection.Delegates[i].Delegate.Invoke(param, param1, param2);
            }
        }
        // foreach (var @delegate in delegateCollection.Delegates)
        // {
        //     @delegate.Delegate?.Invoke(param);
        // }
    }
    //public static void Invoke<T, TY, TR, AD>(this DelegateCollection<Action<T, TY, TR, AD>> delegateCollection, T param, TY param1, TR param2, AD param3)
    //{
    //    if (delegateCollection == null || delegateCollection.Delegates == null)
    //    {
    //        return;
    //    }

    //    for (int i = delegateCollection.Delegates.Count - 1; i >= 0; i--)
    //    {
    //        if (delegateCollection.Delegates[i].Delegate != null)
    //        {
    //            delegateCollection.Delegates[i].Delegate.Invoke(param, param1, param2, param3);
    //        }
    //    }
        // foreach (var @delegate in delegateCollection.Delegates)
        // {
        //     @delegate.Delegate?.Invoke(param);
        // }
    //}
}