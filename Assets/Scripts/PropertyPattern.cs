//Property Pattern (Özellik Deseni): Bir nesnenin belirli bir özelliğinin değerine göre
//desen eşleştirmesi yapmak için kullanılır. Bu, özellikle nesnelerin içerdiği özelliklere
//dayalı kararlar vermek için kullanışlıdır.

using UnityEngine;

namespace PatternMatching
{
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
}
