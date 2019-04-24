using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author: Jacopo Greenslade
// Why not make it static and just make the original objects responsible for the pools
public class ObjectPool {

    private List<GameObject> pool;

    // Store this so you can instantiate objects if necessary
    private GameObject o;

    public void PopulatePool(MonoBehaviour caller, int poolSize, GameObject obj)
    {
        pool = new List<GameObject>();
        // Store object for later use
        o = obj;

        for (int i = 0; i < poolSize; i++)
        {
            pool.Add(CreateObject(obj));
        }
    }

    public GameObject GetObject()
    {
        foreach (var o in pool)
        {
            if (!o.activeInHierarchy)
            {
                return o;
            }
        }
        var go = CreateObject(o);
        pool.Add(go);
        return go;
    }

    private GameObject CreateObject(GameObject obj)
    {
        var go = Object.Instantiate(obj);
        go.SetActive(false);
        return go;
    }
}
