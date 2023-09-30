//Var Pattern (Değişken Deseni): Bir nesneyi bir değişkene atarken
//veya bir deseni daha sonra kullanmak için saklarken kullanılır.

using UnityEngine;

namespace PatternMatching
{
    public class VarPattern : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var name = "John";
            if (name is string)
            {
                // obj bir string türündeyse, str değişkeni bu türe dönüştürülür
                // ve bu blok içinde kullanılabilir
                Debug.Log($"obj is a string: {name}");
            }
        }
    }
}


