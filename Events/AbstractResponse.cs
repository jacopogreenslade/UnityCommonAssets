using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Jacopo Greenslade

public abstract class AbstractResponse : ScriptableObject {
	public virtual void InvokeResponse(MonoBehaviour caller) {
		Debug.Log("Invoked Generic Response");
	}
}
