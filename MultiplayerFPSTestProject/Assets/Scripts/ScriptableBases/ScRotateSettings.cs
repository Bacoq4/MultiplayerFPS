using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rotating
{
    [CreateAssetMenu]
    public class ScRotateSettings : ScriptableObject
    {
        [SerializeField] private float _mouseSensitivity;
        [SerializeField] private float _minRotationClamp;
        [SerializeField] private float _maxRotationClamp;

        public float MouseSensitivity
        {
            get => _mouseSensitivity;
            set => _mouseSensitivity = value;
        }

        public float MinRotationClamp => _minRotationClamp;
        public float MaxRotationClamp => _maxRotationClamp;

    }

}
