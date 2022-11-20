using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using Moving;
using UnityEngine;

public class PlayerAnimController : NetworkBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private ScAnimationInputData animationInputData;
    private static readonly int RightLeft = Animator.StringToHash("RightLeft");
    private static readonly int UpDown = Animator.StringToHash("UpDown");
    private static readonly int IsMoving = Animator.StringToHash("isMoving");

    void Update()
    {
        // if (Math.Abs(animationInputData.Horizontal) > 0 || Math.Abs(animationInputData.Vertical) > 0)
        // {
        //     animator.SetBool(IsMoving, true);
        // }
        // else
        // {
        //     animator.SetBool(IsMoving, false);
        // }
        if (!isLocalPlayer)
            return;
        animator.SetFloat(RightLeft, animationInputData.Horizontal);  
        animator.SetFloat(UpDown, animationInputData.Vertical);
    }
}
