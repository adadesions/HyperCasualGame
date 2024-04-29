using UnityEngine;

namespace Game.Scripts.Managers
{
    public class SettingManager : MonoBehaviour
    {
        
        void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
