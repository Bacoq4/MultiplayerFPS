using Mirror;
using UnityEngine;

namespace Moving
{
    public class Mover : NetworkBehaviour
    {
        [SerializeField] private ScMoveInputData InputData;
        [SerializeField] private ScMoveSettings moveSettings;
        [SerializeField] private CharacterController charController;
        void Update()
        {
            if (!isLocalPlayer)
                return;

            Vector3 moveVec = transform.right * InputData.Horizontal + transform.forward * InputData.Vertical;
            charController.Move(moveVec.normalized * (Time.deltaTime * moveSettings.Speed));
        }
    }
}

