using System;
using UnityEngine;

namespace LearningPattern.HumbleObject
{
    public class Bird : MonoBehaviour
    {
        [SerializeField] private float _maxHeight;
        [SerializeField] private float _minHeight;

        private void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            Move(vertical);
        }

        private void Move(float vertical)
        {
            transform.position += Vector3.up * vertical;
            if(transform.position.y > _maxHeight)
                transform.position = new Vector3(transform.position.x, _maxHeight, transform.position.z);
            if(transform.position.y < _minHeight)
                transform.position = new Vector3(transform.position.x, _minHeight, transform.position.z);
        }
    }
}