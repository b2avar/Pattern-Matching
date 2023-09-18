using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarPattern : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var name = "John";
        if (name is string str)
        {
            // obj bir string türündeyse, str değişkeni bu türe dönüştürülür
            // ve bu blok içinde kullanılabilir
            Debug.Log($"obj is a string: {str}");
        }
    }
}
