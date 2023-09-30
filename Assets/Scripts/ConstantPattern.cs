//Constant Pattern (Sabit Deseni): Bir nesnenin belirli bir sabit değere eşit olup
//olmadığını kontrol etmek için kullanılır.

using UnityEngine;

namespace PatternMatching
{
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
}
