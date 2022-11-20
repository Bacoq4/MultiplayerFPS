using UnityEngine;


namespace Moving
{
    [CreateAssetMenu]
    public class ScMoveInputData : ScriptableObject
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

}
