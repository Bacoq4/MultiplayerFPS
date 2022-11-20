using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

namespace Shooting
{
    public class ShootingController : NetworkBehaviour
    {
        [SerializeField] private Shooter shooter;
        void Update()
        {
            if (!isLocalPlayer)
                return;
            if (Input.GetMouseButtonDown(0))
            {
                shooter.Shoot();
            }
        }
    }

}
