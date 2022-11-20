using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;


namespace Rotating
{
    public class FreeRotator : NetworkBehaviour
    {
        private float xRotation;
        [SerializeField] private ScMouseInputData mouseInputData;
        [SerializeField] private ScRotateSettings rotateSettings;
        [SerializeField] private Transform body;
        [SerializeField] private Camera cam;
        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        void Update()
        {
            if (!isLocalPlayer)
                return;
            
            float mouseX = mouseInputData.MouseX * rotateSettings.MouseSensitivity * Time.deltaTime;   
            float mouseY = mouseInputData.MouseY * rotateSettings.MouseSensitivity * Time.deltaTime;
            
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, rotateSettings.MinRotationClamp, rotateSettings.MaxRotationClamp);
             
            cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
            transform.Rotate(Vector3.up * mouseX);
        }
    }

}
