using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Jacopo Greenslade

public class ResponseListener : GameEventListener {

	public AbstractResponse Response;

	public override void OnEventRaised() {
		Response.InvokeResponse(this);
	}
}
