using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantPattern : MonoBehaviour
{
    private void Start()
    {
        var value = 0;
        switch (value)
        {
            case 0:
                Debug.Log("value sıfıra eşittir.");
                break;
            case 1:
                Debug.Log("value bir.");
                break;
            default:
                Debug.Log("value diğer bir değere eşittir.");
                break;
        }
    }
}
