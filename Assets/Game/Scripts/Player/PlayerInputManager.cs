using UnityEngine;

namespace Game.Scripts.Player
{
    public class PlayerInputManager : MonoBehaviour
    {
        private PlayerInputs _playerInputs;
        private PlayerController _playerController; 
            
        private void Awake()
        {
            _playerInputs = new PlayerInputs();
            _playerController = GetComponent<PlayerController>();
        }

        private void OnEnable()
        {
            _playerInputs.Enable();
        }

        private void OnDisable()
        {
            _playerInputs.Disable();
        }

        private void FixedUpdate()
        {
            var moveValue = _playerInputs.Movements.Move.ReadValue<Vector2>();
            _playerController.Move(moveValue);
            
        }
    }
}
