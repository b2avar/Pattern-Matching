//Recursive Pattern (Rekürsif Desen), bir nesnenin kendisine benzer
//alt öğeler içeren bir nesneyi eşleştirmek için kullanılır. 

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PatternMatching
{
    public class RecursivePattern : MonoBehaviour
    {
        private void Start()
        {
            var rootObject = this.gameObject;
            var allObjects = new List<GameObject>();
            
            CollectAllObjects(rootObject, allObjects);
            
            foreach (var obj in allObjects
                         .Where(obj => obj is { name: "Cube" }))
            {
                Debug.Log($"{obj.name} is a GameObject named Cube.");
            }
            
        }

        private static void CollectAllObjects(GameObject parentObject, ICollection<GameObject> objectList)
        {
            objectList.Add(parentObject);
            foreach (Transform child in parentObject.transform)
            {
                CollectAllObjects(child.gameObject, objectList);
            }
        }
    }
}

