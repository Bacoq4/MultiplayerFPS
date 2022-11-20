using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScMoveSettings : ScriptableObject
{
    [SerializeField] private float _speed;

    public float Speed => _speed;
}
