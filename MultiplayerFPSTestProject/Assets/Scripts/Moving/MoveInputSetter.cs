using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

namespace Moving
{
    public class MoveInputSetter : NetworkBehaviour
    {
        [SerializeField] private ScMoveInputData InputData;
        void Update()
        {
            if (!isLocalPlayer)
                return;
            
            InputData.Horizontal = Input.GetAxisRaw("Horizontal");
            InputData.Vertical = Input.GetAxisRaw("Vertical");
        }
    }
 

}


