using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyPattern : MonoBehaviour
{
    private void Start()
    {
        var obj = GameObject.Find("Sphere");
        var collider = obj.GetComponent<SphereCollider>();

        Debug.Log(collider is SphereCollider { isTrigger: false, radius: 0.5f }
            ? "This is a GameObject named Sphere."
            : "Could not find a GameObject named Sphere.");
    }
}
