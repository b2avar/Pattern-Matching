//Type Pattern (Tür Deseni): Bir nesnenin belirli bir türe
//uyup uymadığını kontrol etmek için kullanılır.
//Bu, is ve as anahtar kelimeleriyle gerçekleştirilir.

using UnityEngine;

namespace PatternMatching
{
    public class TypePattern : MonoBehaviour
    {
        private void Start()
        {
            GameObject obj = GameObject.Find("Cube");

            if (obj != null)
            {
                Debug.Log("This is a game object");

                if (obj.TryGetComponent<Rigidbody>(out Rigidbody rb))
                {
                    Debug.Log("This GameObject also contains a Rigidbody.");
                }
            
                else if (obj.TryGetComponent<MeshRenderer>(out MeshRenderer renderer))
                {
                    Debug.Log("This GameObject also contains a MeshRenderer.");
                }
            }

            else
            {
                Debug.Log("Could not find a GameObject named Cube.");
            }
        }
    } 
}


