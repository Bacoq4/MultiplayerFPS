using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScBulletData : ScriptableObject
{
    [SerializeField] private float _damageAmount;
    [SerializeField] private float _speed;

    public float DamageAmount => _damageAmount;
    public float Speed => _speed;
}
