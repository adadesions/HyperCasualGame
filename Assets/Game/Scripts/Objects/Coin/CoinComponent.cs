using System;
using UnityEngine;

namespace Game.Scripts.Objects.Coin
{
    public class CoinComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _coin;
        [SerializeField] private GameObject _effect;
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(_coin);
                Destroy(_effect, 1.0f);
                Destroy(gameObject, 1.0f);
            }
        }
    }
}
