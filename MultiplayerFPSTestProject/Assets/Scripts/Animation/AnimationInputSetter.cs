using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class AnimationInputSetter : NetworkBehaviour
{
    [SerializeField] private ScAnimationInputData animationInputData;

    void Update()
    {
        if (!isLocalPlayer)
            return;
            
        animationInputData.Horizontal = Input.GetAxis("Horizontal");
        animationInputData.Vertical = Input.GetAxis("Vertical");        
    }
}
