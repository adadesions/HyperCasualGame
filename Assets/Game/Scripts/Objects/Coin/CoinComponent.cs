using System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Scripts.Objects.Coin
{
    public class CoinComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _coin;
        [SerializeField] private GameObject _effect;
        
        public static event UnityAction OnCoinCollected;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                OnCoinCollected?.Invoke();
                
                Destroy(_coin);
                Destroy(_effect, 1.0f);
                Destroy(gameObject, 1.0f);
            }
        }
    }
}
