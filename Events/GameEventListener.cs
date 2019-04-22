using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Jacopo Greenslade

public abstract class GameEventListener : MonoBehaviour {

	public GameEvent Event;

	public abstract void OnEventRaised();

	public virtual void OnEnable() {
		Event.RegisterListener(this);
	}

	public virtual void OnDisable() {
		Event.UnregisterListener(this);
	}
}
