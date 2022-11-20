using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScAnimationInputData : ScriptableObject
{
    [SerializeField] private float _horizontal;
    [SerializeField] private float _vertical;

    public float Horizontal
    {
        get => _horizontal;
        set => _horizontal = value;
    }

    public float Vertical
    {
        get => _vertical;
        set => _vertical = value;
    }
}
