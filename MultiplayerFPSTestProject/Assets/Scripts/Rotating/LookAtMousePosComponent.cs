using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

namespace Rotating
{
    public class LookAtMousePosComponent : NetworkBehaviour
    {
        private Camera cam;
        private void Start()
        {
            cam = Camera.main;
        }

        void Update()
        {
            if (!isLocalPlayer)
                return;
            Plane plane = new Plane(Vector3.up, Vector3.zero);
            
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (plane.Raycast(ray, out float distance))
            {
                Vector3 rayPoint = ray.origin + ray.direction * distance;
                Vector3 lookPoint = new Vector3(rayPoint.x, transform.position.y, rayPoint.z);
                transform.LookAt(lookPoint);   
            }
        }
    }
}

