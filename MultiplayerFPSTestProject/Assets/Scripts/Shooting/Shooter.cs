using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

namespace Shooting
{
    public class Shooter : NetworkBehaviour
    {
        [SerializeField] private Bullet bulletPrefab;
        [SerializeField] private Transform shootStartPos;
        public void Shoot()
        {
            Bullet bullet = Instantiate(bulletPrefab, shootStartPos.position, shootStartPos.rotation);
        }
    }

}
