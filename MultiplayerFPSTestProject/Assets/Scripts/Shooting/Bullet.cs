using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Bullet : NetworkBehaviour
{
    [SerializeField] private ScBulletData bulletData;

    private void Update()
    {
        transform.position += transform.forward * (bulletData.Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Health>().TakeDamage(bulletData.DamageAmount);
        }
    }
}
