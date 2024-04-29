using System;
using Game.Scripts.Objects.Coin;
using UnityEngine;

namespace Game.Scripts.Managers
{
    public class SoundManager : MonoBehaviour
    {
        private AudioSource _audio;

        private void Awake()
        {
            CoinComponent.OnCoinCollected += OnCoinCollect;
        }

        private void Start()
        {
            _audio = GetComponent<AudioSource>();
        }

        private void OnDestroy()
        {
            CoinComponent.OnCoinCollected -= OnCoinCollect;
        }

        private void OnCoinCollect()
        {
            _audio.Play();
        }
    }
}
