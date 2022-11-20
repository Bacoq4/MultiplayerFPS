using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _healthValue;

    public float HealthValue
    {
        get => _healthValue;
        set => _healthValue = value;
    }

    public void TakeDamage(float damage)
    {
        HealthValue -= damage;
        if (HealthValue <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //Debug.Log(transform.name+" Died");
    }
}
