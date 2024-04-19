using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Lab
{
    public class MyDataStructures : MonoBehaviour
    {
        private Vector2 pos2d;
        private Vector3 pos3d;

        private void Start()
        {
            pos2d = new Vector2(1, 2);
            Debug.Log(pos2d.x + " " + pos2d.y);

            pos3d = new Vector3(1, 2, 3);
            print(pos3d.x + " " + pos3d.y + " " + pos3d.z);
        }

        private void Update()
        {
            throw new NotImplementedException();
        }
    }
    
}