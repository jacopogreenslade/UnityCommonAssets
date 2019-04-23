using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Jacopo Greenslade
public class TriggerResponse : MonoBehaviour {

    public AbstractResponse r;

    public string checkForTag;
  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (checkForTag != "" && other.CompareTag(checkForTag))
        {
            r.InvokeResponse(this);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (checkForTag != "" && other.CompareTag(checkForTag))
        {
            r.InvokeResponse(this);
        }
    }
}
