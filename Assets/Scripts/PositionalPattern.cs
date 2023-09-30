//Positional Pattern (Pozisyonel Desen): Bir nesnenin özelliklerine değil,
//sırasına göre desen eşleştirmesi yapmak için kullanılır. Bu, özellikle
//koleksiyonlar veya dizilerdeki verilere erişirken ve bu verileri belirli
//bir sıraya göre işlerken kullanışlıdır.

using UnityEngine;

namespace PatternMatching
{
    public class PositionalPattern : MonoBehaviour
    {
        private GameObject[] _pattern;

        private void Awake()
        {
            _pattern = GameObject.FindGameObjectsWithTag("PositionalPattern");
        }

        private void Start()
        {
            foreach (var obj in _pattern)
            {
                Debug.Log(_pattern.Length);
                if (obj.transform.position is { x: > 0, y: > 0, z: > 0 })
                {
                    Debug.Log($"{obj.name} has positive x and y and z coordinates");
                }
            }
        }
    }
}
