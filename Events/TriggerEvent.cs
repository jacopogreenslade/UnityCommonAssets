using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Jacopo Greenslade
public class TriggerEvent : MonoBehaviour {
    public GameEvent g;
  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (g)
            g.Raise();
    }

    void OnTriggerEnter(Collider other)
    {
        if (g)
            g.Raise();
    }
}
