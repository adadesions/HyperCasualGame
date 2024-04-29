using System;
using Cinemachine;
using UnityEngine;

namespace Game.Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {
        private CharacterController _characterController;
        
        [Header("Movement Settings")]
        [Range(1.0f, 10.0f)]
        [SerializeField] private float _moveSpeed = 1.0f;
        
        [Range(1.0f, 10.0f)]
        [SerializeField] private float _rotateSpeed = 3.0f;

        [Header("Camera Settings")] [SerializeField]
        private CinemachineFreeLook _vCam;
        
        private Vector3 _velocity;
        private Vector3 _camDir;
        private Camera _mainCam;
        private Vector3 _moveDir;
        private float _targetAngle;
        private float _angle;

        private void Start()
        {
            _mainCam = Camera.main;
            _characterController = GetComponent<CharacterController>();
        }

        public void Move(Vector2 moveValue)
        {
            _velocity = new Vector3(moveValue.x, 0, moveValue.y);
            _camDir = Vector3.Scale(_mainCam.transform.forward, new Vector3(1, 0, 1)).normalized;
            _moveDir = Quaternion.FromToRotation(Vector3.forward, _camDir) * _velocity.normalized;
            
            if (_velocity.magnitude >= 0.1f)
            {
                _targetAngle = Mathf.Atan2(_moveDir.x, _moveDir.z) * Mathf.Rad2Deg;
                _angle = Mathf.LerpAngle(transform.eulerAngles.y, _targetAngle, Time.fixedDeltaTime * _rotateSpeed);
                transform.rotation = Quaternion.Euler(0, _angle, 0);
                _moveDir = transform.forward * (_moveSpeed * Time.fixedDeltaTime);
                _characterController.Move(_moveDir);
            }
        }
        
        public void CameraControlling(Vector2 cameraValue)
        {
            _vCam.m_XAxis.m_InputAxisName = "";
            _vCam.m_YAxis.m_InputAxisName = "";
            
            _vCam.m_XAxis.m_InputAxisValue = cameraValue.x;
            _vCam.m_YAxis.m_InputAxisValue = cameraValue.y;

        }
    }
}
