using UnityEngine;
using UnityEditor;

// Author: Jacopo Greenslade
[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor {

	private GameEvent instance;

	void Awake() {
		instance = (GameEvent) target;
	}
	
	public override void OnInspectorGUI() {
		if (GUILayout.Button("Raise")) {
			instance.Raise();
		}
	}
}
