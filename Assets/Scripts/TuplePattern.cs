using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuplePattern : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GameObject obj = new GameObject("Cube");

        SpriteRenderer renderer = obj.AddComponent<SpriteRenderer>();
        renderer.color = Color.red;
        
        var result = GetRandomNumber();
        obj.transform.position = new Vector2(result.Item1, result.Item2);
    }
    
    private (int, int) GetRandomNumber()
    {
        return (Random.Range(-10, 10), Random.Range(0, 10));
    }
}
