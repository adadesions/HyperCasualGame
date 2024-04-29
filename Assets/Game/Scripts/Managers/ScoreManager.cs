using System;
using Game.Scripts.Objects.Coin;
using UnityEngine;

namespace Game.Scripts.Managers
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private int _score;

        private void Awake()
        {
            CoinComponent.OnCoinCollected += OnCoinCollect;
        }

        private void OnDestroy()
        {
            CoinComponent.OnCoinCollected -= OnCoinCollect;
        }

        private void OnCoinCollect()
        {
            _score += 10;
            print($"New Score: {_score}");
        }
    }
}
