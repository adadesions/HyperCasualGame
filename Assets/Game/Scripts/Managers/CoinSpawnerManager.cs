using System;
using Unity.Mathematics;
using UnityEngine;

namespace Game.Scripts.Managers
{
    public class CoinSpawnerManager : MonoBehaviour
    {
        [SerializeField] private GameObject _coinPrefab;
        [SerializeField] private int _amountToSpawn;
        [SerializeField] private GameObject _parent;
        
        // Start is called before the first frame update
        void Start()
        {
            CoinSpawn();
        }

        private void Update()
        {
            RefillCoin();
        }

        private void RefillCoin()
        {
            if (_parent.transform.childCount.Equals(0))
            {
                CoinSpawn();
            }
        }

        private void CoinSpawn()
        {
            for (var i = 0; i < _amountToSpawn; i++)
            {
                var spawnPos = new Vector3(0f, 1f, i * 5);
                var go = Instantiate(_coinPrefab, spawnPos, quaternion.identity);
                go.transform.SetParent(_parent.transform);
            }
        }
    }
}
