using System;
using UnityEngine;

namespace LearningPattern.HumbleObject
{
    public class BirdSplit : MonoBehaviour, IBird
    {
        private BirdController _birdController;

        [SerializeField] private float _maxHeight = 3f;
        
        [SerializeField] private float _minHeight = -3f;

        public Vector3 Position
        {
            get => transform.position;
            set => transform.position = value;
        }

        public float MaxHeight => _maxHeight;

        public float MinHeight => _minHeight;

        private void Awake()
        {
            _birdController = new BirdController(this);
        }

        private void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            _birdController.Move(vertical);
        }

      
    }
}