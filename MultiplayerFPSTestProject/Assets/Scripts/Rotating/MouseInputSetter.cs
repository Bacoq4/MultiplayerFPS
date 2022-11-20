using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

// Mouse Inputs will be used for rotating thats why it is under rotating namespace
namespace Rotating
{
    public class MouseInputSetter : NetworkBehaviour
    {
        [SerializeField] private ScMouseInputData mouseInputData;

        void Update()
        {
            if (!isLocalPlayer)
                return;
            mouseInputData.MouseX = Input.GetAxis("Mouse X");
            mouseInputData.MouseY = Input.GetAxis("Mouse Y");
        }
    }

}
