#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace DarkTonic.MasterAudio.EditorScripts
{
    [CustomPropertyDrawer(typeof(ParameterCommandAttribute))]
    // ReSharper disable once CheckNamespace
    public class ParamCommandPropertyDrawer : PropertyDrawer
    {
        // ReSharper disable once InconsistentNaming
        public int index;
        // ReSharper disable once InconsistentNaming
        public bool typeIn;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (!typeIn)
            {
                return base.GetPropertyHeight(property, label);
            }
            return base.GetPropertyHeight(property, label) + 16;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var ma = MasterAudio.SafeInstance;
            // ReSharper disable once RedundantAssignment
            var commandName = "[Type In]";

            var commandNames = new List<string>();

            var labelText = label.text;
            if (ma != null)
            {
                commandNames.AddRange(ma.ParameterCommandNames);
            }
            else
            {
                commandNames.AddRange(MasterAudio.ParameterCommandHardCodedNames);
                labelText += " (MA not in Scene)";
            }

#if UNITY_2023_1_OR_NEWER
            var creators = Object.FindObjectsByType<DynamicSoundGroupCreator>(FindObjectsInactive.Include, FindObjectsSortMode.None) as DynamicSoundGroupCreator[];
#else
            var creators = Object.FindObjectsOfType(typeof(DynamicSoundGroupCreator)) as DynamicSoundGroupCreator[];
#endif

            // ReSharper disable once PossibleNullReferenceException
            foreach (var dsgc in creators)
            {
                foreach (var paramCmd in dsgc.parameterCommands)
                {
                    commandNames.Add(paramCmd.CommandName);
                }
            }

            commandNames.Sort();
            if (commandNames.Count > 1)
            { // "type in" back to index 0 (sort puts it at #1)
                commandNames.Insert(0, commandNames[1]);
                commandNames.RemoveAt(2);
            }

            if (commandNames.Count == 0)
            {
                index = -1;
                typeIn = false;
                property.stringValue = EditorGUI.TextField(position, labelText, property.stringValue);
                return;
            }

            index = commandNames.IndexOf(property.stringValue);

            if (typeIn || index == -1)
            {
                index = 0;
                typeIn = true;
                position.height -= 16;
            }

            index = EditorGUI.Popup(position, labelText, index, commandNames.ToArray());
            commandName = commandNames[index];

            switch (commandName)
            {
                case "[Type In]":
                    typeIn = true;
                    position.yMin += 16;
                    position.height += 16;
                    EditorGUI.BeginChangeCheck();
                    property.stringValue = EditorGUI.TextField(position, labelText, property.stringValue);
                    EditorGUI.EndChangeCheck();
                    break;
                default:
                    typeIn = false;
                    property.stringValue = commandName;
                    break;
            }
        }
    }
}
#endif