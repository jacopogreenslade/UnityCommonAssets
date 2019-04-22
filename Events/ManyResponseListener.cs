using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Jacopo Greenslade

public class ManyResponseListener : GameEventListener
{

    public List<AbstractResponse> Responses;

    public override void OnEventRaised()
    {
        foreach (AbstractResponse r in Responses)
        {
            r.InvokeResponse(this);
        }
    }
}
