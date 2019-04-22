using UnityEngine;
using UnityEditor;

// Author: Jacopo Greenslade
/// <summary>
/// Defines the <see cref="ResponseListenerEditor" />
/// </summary>
[CustomEditor(typeof(ResponseListener))]

public class ResponseListenerEditor : Editor
{
    /// <summary>
    /// Defines the instance
    /// </summary>
    private ResponseListener instance;

    /// <summary>
    /// The Awake
    /// </summary>
    internal void Awake()
    {
        instance = (ResponseListener)target;
    }

    /// <summary>
    /// The OnInspectorGUI
    /// </summary>
    public override void OnInspectorGUI()
    {
        instance.Event = (GameEvent)EditorGUILayout.ObjectField("Event", instance.Event, typeof(GameEvent), false, null);
        instance.Response = (AbstractResponse)EditorGUILayout.ObjectField("Response", instance.Response, typeof(AbstractResponse), false, null);
        // If null have a + button that adds a new response

        if (instance.Response == null)
        {
            //AbstractResponse response = (PlayerDeath) ScriptableObject.CreateInstance(typeof(PlayerDeath));

            //AssetDatabase.CreateAsset(response, "Assets/NewPlayerDeath.asset");

            //instance.Response = response;

        }
    }

    
}
