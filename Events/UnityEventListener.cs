using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Author: Jacopo Greenslade

public class UnityEventListener : GameEventListener {

	public UnityEvent Response;

	public override void OnEventRaised() {
		Response.Invoke();
	}
}
