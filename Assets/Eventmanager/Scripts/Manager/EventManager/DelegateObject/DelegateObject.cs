using System;
using UnityEditor;
using UnityEngine;

namespace _Game.Scripts.Manager.EventManager.DelegateObject
{
    public class DelegateObject<T> where T : Delegate
    {
#if UNITY_EDITOR && DEVELOPER_MODE
    [SerializeField]
    private string _detail;
#endif
        private T _delegate;
        public T Ref => _delegate;

        public DelegateObject()
        {
        }

        public DelegateObject(T @delegate)
        {
            Set(@delegate);
        }

        public void Set(T @delegate)
        {
            _delegate = @delegate;
#if UNITY_EDITOR && DEVELOPER_MODE
        _detail = @delegate.Target + "." + @delegate.Method.Name;
#endif
        }

        public void Remove(T @delegate)
        {
            _delegate = null;
#if UNITY_EDITOR && DEVELOPER_MODE
        _detail = @delegate.Target + "Remove." + @delegate.Method.Name;
#endif
        }

        public void Clear()
        {
            _delegate = null;
#if UNITY_EDITOR && DEVELOPER_MODE
        _detail = string.Empty;
#endif
        }

#if UNITY_EDITOR
        public int Count()
        {
            return _delegate != null ? 1 : 0;
        }

        public string GetTarget()
        {
            return _delegate != null && _delegate.Target != null ? _delegate.Target.ToString() : "";
        }
#endif
    }
#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(DelegateObject<>))]
    public class DelegateObjectDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.serializedObject == null)
            {
                return;
            }

            GUI.enabled = false;
            var name = property.FindPropertyRelative("_detail");

            if (string.IsNullOrEmpty(name.stringValue))
            {
                GUI.color = Color.yellow;
                EditorGUI.TextField(position, label.text, "[Null]");
                GUI.color = Color.white;
                GUI.enabled = true;
                return;
            }

            GUI.color = Color.green;
            EditorGUI.TextField(position, label.text, name.stringValue);
            GUI.color = Color.white;
            GUI.enabled = true;
        }
    }
#endif
}