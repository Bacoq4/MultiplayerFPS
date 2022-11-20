using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mouse Inputs will be used for rotating thats why it is under rotating namespace
namespace Rotating
{
    [CreateAssetMenu]
    public class ScMouseInputData : ScriptableObject
    {
        [SerializeField] private float _mouseX;
        [SerializeField] private float _mouseY;

        public float MouseX
        {
            get => _mouseX;
            set => _mouseX = value;
        }

        public float MouseY
        {
            get => _mouseY;
            set => _mouseY = value;
        }
    }
}

