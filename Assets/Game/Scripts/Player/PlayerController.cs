using System;
using UnityEngine;

namespace Game.Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {
        private CharacterController _characterController;
        [SerializeField] private float _moveSpeed = 1.0f;

        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        public void Move(Vector2 moveValue)
        {
            var moveDirection = new Vector3(moveValue.x, 0, moveValue.y);
            _characterController.Move(moveDirection * (Time.fixedDeltaTime * _moveSpeed));
        }
    }
}
