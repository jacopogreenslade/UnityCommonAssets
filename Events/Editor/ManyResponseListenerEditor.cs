using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

// Author: Jacopo Greenslade
/// <summary>
/// Defines the <see cref="ResponseListenerEditor" />
/// </summary>
[CustomEditor(typeof(ManyResponseListener))]
public class ManyResponseListenerEditor : Editor
{
    /// <summary>
    /// Defines the instance
    /// </summary>
    private ManyResponseListener instance;

    private List<bool> showResponses;

    /// <summary>
    /// The Awake
    /// </summary>
    internal void Awake()
    {
        instance = (ManyResponseListener) target;
        showResponses = new List<bool>();
        for (int i = 0; i < instance.Responses.Count; i++)
        {
            showResponses.Add(false);
        }
    }

    /// <summary>
    /// The OnInspectorGUI
    /// </summary>
    public override void OnInspectorGUI()
    {
        instance.Event = (GameEvent)EditorGUILayout.ObjectField("Event", instance.Event, typeof(GameEvent), false, null);

        Rect rect = GUILayoutUtility.GetRect(0, 40, GUILayout.ExpandWidth(true));
        GUI.Box(rect, "Drop Response objects here!");
        if (rect.Contains(Event.current.mousePosition) )
        {
            if (Event.current.type == EventType.DragUpdated)
            {
                DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
                Event.current.Use();
            }

            if (Event.current.type == EventType.DragPerform)
            {
                foreach (Object o in DragAndDrop.objectReferences)
                {
                    AbstractResponse r = (AbstractResponse) o;
                    if (r != null)
                    {
                        instance.Responses.Add(r);
                        showResponses.Add(true);
                    }
                }
                Event.current.Use();
            }
        }

        for (int i = 0; i < instance.Responses.Count; i++)
        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.BeginHorizontal();
            showResponses[i] = EditorGUILayout.Foldout(showResponses[i], "Response " + (i + 1));
            instance.Responses[i] = (AbstractResponse)
                    EditorGUILayout.ObjectField("", instance.Responses[i], typeof(AbstractResponse), false, null);

            if (instance.Responses[i] == null)
            {
                instance.Responses.RemoveAt(i);
                showResponses.RemoveAt(i);
                break;
            } 

            EditorGUILayout.EndHorizontal();
            if (showResponses[i])
            {
                CreateEditor(instance.Responses[i]).OnInspectorGUI();
            }
            EditorGUILayout.EndVertical();
        }        
    }

    
}
